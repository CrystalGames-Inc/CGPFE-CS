namespace CGPFE.God.Creation.General.Feat.Properties.Prerequisites;

public class SkillRankPrerequisite(string skillName, int minRanks) : IPrerequisite {

	private string SkillName { get; set; } = skillName;
	private int MinRanks { get; set; } = minRanks;

	public bool IsSatisfiedBy(Player.Player player) {
		return player.GetMatchingSkill(SkillName).Bonus.Ranks >= MinRanks;
	}
}