using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class GreaterTwoWeaponFighting: Feat {
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

	public override void Benefits() {
		throw new NotImplementedException();
	}
}