using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ImprovedUnarmedStrike(): Domain.Characters.Feats.Properties.Feat("Improved Unarmed Strike", FeatType.Combat) {
	public override bool CanAcquire() {
		return true;
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}