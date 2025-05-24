using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class ShieldMaster: Feat {
	public ShieldMaster() : base("Shield Master", FeatType.Combat) {
		Prerequisites = [
			new FeatPrerequisite("Improved Shield Bash"),
			new FeatPrerequisite("Shield Proficiency"),
			new FeatPrerequisite("Shield Slam"),
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