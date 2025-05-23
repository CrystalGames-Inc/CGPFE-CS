using CGPFE.Data.Constants;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class PointBlankShot(): Feat("Point-Blank Shot", FeatType.Combat) {
	public override bool CanAcquire() {
		return true;
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}