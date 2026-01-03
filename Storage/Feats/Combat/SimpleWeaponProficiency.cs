using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class SimpleWeaponProficiency() : Characters.Feats.Feat("Simple Weapon Proficiency", FeatType.Combat) {
	public override bool CanAcquire() {
		return true;
	}

	public override void ApplyBenefits() {
		throw new NotImplementedException();
	}
}