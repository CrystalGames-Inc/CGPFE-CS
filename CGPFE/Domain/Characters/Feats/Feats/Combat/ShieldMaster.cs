using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ShieldMaster: Domain.Characters.Feats.Properties.Feat {
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