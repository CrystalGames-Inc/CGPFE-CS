using CGPFE.Data.Constants;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class CatchOffGuard(): Feat("Catch Off-Guard", FeatType.Combat) {
	public override bool CanAcquire() {
		return true;
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}