using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ImprovedUnarmedStrike(): Characters.Feats.Feat("Improved Unarmed Strike", FeatType.Combat) {
	public override bool CanAcquire() {
		return true;
	}

	public override void ApplyBenefits() {
		throw new NotImplementedException();
	}
}