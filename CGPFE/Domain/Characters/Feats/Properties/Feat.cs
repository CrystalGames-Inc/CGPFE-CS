using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Player;

namespace CGPFE.Domain.Characters.Feats.Properties;

public abstract class Feat(string name, FeatType type = FeatType.General) {
    public string Name { get; } = name;
    public FeatType Type { get; } = type;
    protected List<CGPFE.Domain.Characters.Feats.Properties.Prerequisite.IPrerequisite> Prerequisites { get; init; }

    public abstract bool CanAcquire();
    public abstract void Benefits();

    // New: player-aware overloads (default to calling parameterless implementations)
    public virtual bool CanAcquire(Player player) => CanAcquire();
    public virtual void Benefits(Player player) => Benefits();
}