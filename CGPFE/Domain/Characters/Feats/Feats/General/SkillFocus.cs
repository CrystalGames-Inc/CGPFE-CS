using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class SkillFocus: Domain.Characters.Feats.Properties.Feat {

	private string SkillName { get; }

	public SkillFocus() : base("Skill Focus") {
	}

	public SkillFocus(string skillName) : base("Skill Focus") { 
		SkillName = skillName;
	}
	
	public override bool CanAcquire() {
		return true;
	}

	public override void Benefits() {
		if(PlayerDataManager.Instance.Player.GetMatchingSkill(SkillName).Bonus.Ranks >= 10)
			PlayerDataManager.Instance.Player.GetMatchingSkill(SkillName).Bonus.MiscMod += 6;
		else
			PlayerDataManager.Instance.Player.GetMatchingSkill(SkillName).Bonus.MiscMod += 3;
	}
}