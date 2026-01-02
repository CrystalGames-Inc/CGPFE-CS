using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class MasterCraftsman : Domain.Characters.Feats.Properties.Feat {
	public MasterCraftsman() : base("Master Craftsman") {
		Prerequisites = [
			new SkillRankPrerequisite("Craft", 5),
			new SkillRankPrerequisite("Profession", 5)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites[0].IsSatisfiedBy(PlayerDataManager.Instance.Player) || Prerequisites[1].IsSatisfiedBy(PlayerDataManager.Instance.Player);
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}