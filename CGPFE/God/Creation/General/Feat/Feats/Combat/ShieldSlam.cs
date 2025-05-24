using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class ShieldSlam : Feat {
	public ShieldSlam() : base("Shield Slam", FeatType.Combat) {
		Prerequisites = [
			new FeatPrerequisite("Improved Shield Bash"),
			new FeatPrerequisite("Shield Proficiency"),
			new FeatPrerequisite("Two-Weapon Fighting"),
			new ValuePrerequisite("Bab", 6)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}