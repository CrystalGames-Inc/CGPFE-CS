using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ShatterDefenses: Characters.Feats.Feat {
	public ShatterDefenses() : base("Shatter Defenses", FeatType.Combat) {
		Prerequisites = [
			new FeatPrerequisite("Weapon Focus"),
			new FeatPrerequisite("Dazzling Display"),
			new ValuePrerequisite("Bab", 6),
			//TODO Add specific weapon proficiency
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void ApplyBenefits() {
		throw new NotImplementedException();
	}
}