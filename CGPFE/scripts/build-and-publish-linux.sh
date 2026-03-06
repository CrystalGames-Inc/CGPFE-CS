#!/usr/bin/env bash
set -euo pipefail

# Usage:
# ./scripts/build-and-publish-linux.sh [solution.sln] [linux-x64] [Release]
SOLUTION="${1:-$(ls *.sln 2>/dev/null || true)}"
RID="${2:-linux-x64}"
CONFIG="${3:-Release}"
OUTDIR="./publish/${RID}"

if [ -z "$SOLUTION" ]; then
  echo "No .sln found in repo root. Pass the solution file as first arg."
  exit 1
fi

echo "Solution: $SOLUTION"
echo "RID: $RID  Config: $CONFIG"
echo

echo "Restoring..."
dotnet restore "$SOLUTION"

echo "Building solution (libraries and projects)..."
dotnet build "$SOLUTION" -c "$CONFIG" --no-restore

echo
echo "Library DLLs are now in each project's bin/$CONFIG/<TFM>/ (e.g. bin/$CONFIG/net8.0/)"
echo

# Find a project that declares an executable (OutputType=Exe). If none, skip publishing.
PUBLISH_PROJECT="$(grep -R --include='*.csproj' -l '<OutputType>Exe</OutputType>' . | head -n1 || true)"

if [ -z "$PUBLISH_PROJECT" ]; then
  echo "No executable project detected (no <OutputType>Exe</OutputType> in any .csproj)."
  echo "If you want to publish a specific project, pass its path via PUBLISH_PROJECT env var."
  exit 0
fi

echo "Found executable project to publish: $PUBLISH_PROJECT"
mkdir -p "$OUTDIR"

echo "Publishing $PUBLISH_PROJECT for $RID..."
dotnet publish "$PUBLISH_PROJECT" -c "$CONFIG" -r "$RID" \
  --self-contained true \
  -p:PublishSingleFile=true \
  -p:PublishTrimmed=true \
  -p:PublishReadyToRun=true \
  -o "$OUTDIR"

echo "Making files executable..."
chmod +x "$OUTDIR"/* || true

# Create a small runtime wrapper
cat > "$OUTDIR/run.sh" <<'EOF'
#!/usr/bin/env bash
DIR="$(cd "$(dirname "$0")" && pwd)"
# Execute the single-file binary (assumes single binary present)
BIN="$(find "$DIR" -maxdepth 1 -type f ! -name run.sh | head -n1)"
exec "$BIN" "$@"
EOF
chmod +x "$OUTDIR/run.sh"

echo "Packaging $OUTDIR into publish-${RID}.tar.gz"
tar -czf "publish-${RID}.tar.gz" -C "$(dirname "$OUTDIR")" "$(basename "$OUTDIR")"

echo "Done. Publish output: $OUTDIR"
echo "Package: publish-${RID}.tar.gz"