using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class MountedCombat: Domain.Characters.Feats.Properties.Feat {
	public MountedCombat() : base("Mounted Combat", FeatType.Combat) {
		Prerequisites = [
			new SkillRankPrerequisite("Ride", 1)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}