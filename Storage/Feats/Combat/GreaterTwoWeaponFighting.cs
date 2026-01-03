using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class GreaterTwoWeaponFighting: Characters.Feats.Feat {
	public GreaterTwoWeaponFighting() : base("Greater Two-Weapon Fighting", FeatType.Combat) {
		Prerequisites = [
			new ValuePrerequisite("Dex", 19),
			new FeatPrerequisite("Improved Two-Weapon Fighting"),
			new FeatPrerequisite("Two-Weapon Fighting"),
			new ValuePrerequisite("Bab", 11)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void ApplyBenefits() {
		throw new NotImplementedException();
	}
}