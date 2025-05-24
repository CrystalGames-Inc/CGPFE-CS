using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class TwoWeaponRend: Feat {
	public TwoWeaponRend() : base("Two-Weapon Rend", FeatType.Combat) {
		Prerequisites = [
			new ValuePrerequisite("Dex", 17),
			new FeatPrerequisite("Double Slice"),
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