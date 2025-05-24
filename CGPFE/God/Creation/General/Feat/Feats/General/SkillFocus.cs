using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.General;

public class SkillFocus(string skillName): Feat("Skill Focus") {

	private string SkillName { get; } = skillName;
	
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