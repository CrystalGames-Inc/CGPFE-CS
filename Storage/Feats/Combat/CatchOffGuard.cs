using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class CatchOffGuard(): Characters.Feats.Feat("Catch Off-Guard", FeatType.Combat) {
	public override bool CanAcquire() {
		return true;
	}

	public override void ApplyBenefits() {
		throw new NotImplementedException();
	}
}