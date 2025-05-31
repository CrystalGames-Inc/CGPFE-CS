using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class DeadlyStroke: Domain.Characters.Feats.Properties.Feat {
	public DeadlyStroke() : base("Deadly Stroke", FeatType.Combat) {
		Prerequisites = [
			new FeatPrerequisite("Dazzling Display"),
			new FeatPrerequisite("Greater Weapon Focus"),
			new FeatPrerequisite("Shatter Defenses"),
			new FeatPrerequisite("Weapon Focus"),
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