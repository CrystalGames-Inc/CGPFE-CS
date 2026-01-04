using CGPFE.Domain.Characters.Player;
using Domain.Characters.Feats;

namespace Domain.Characters.Feat.Prerequisites;

public class SkillRankPrerequisite(string skillName, int minRanks) : IPrerequisite
{

    private string SkillName { get; set; } = skillName;
    private int MinRanks { get; set; } = minRanks;

    public bool IsSatisfiedBy(Player player)
    {
        var skill = player.GetMatchingSkill(SkillName);
        return skill is not null && skill.Bonus.Ranks >= MinRanks;
    }
}