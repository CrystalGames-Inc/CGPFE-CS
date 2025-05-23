using CGPFE.Data.Constants;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class ImprovedUnarmedStrike(): Feat("Improved Unarmed Strike", FeatType.Combat) {
	public override bool CanAcquire() {
		return true;
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}