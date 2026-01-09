using Domain.Characters.Feat;
using Domain.Characters.Player;

namespace Storage.Feats.General;

public class SkillFocus : Feat
{

    private string SkillName { get; }

    public SkillFocus() : base("Skill Focus") {
    }

    public SkillFocus(string skillName) : base("Skill Focus") {
        SkillName = skillName;
    }

    public override bool CanAcquire(Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player player) {
        if (player.GetMatchingSkill(SkillName).Bonus.Ranks >= 10)
            player.GetMatchingSkill(SkillName).Bonus.MiscMod += 6;
        else
            player.GetMatchingSkill(SkillName).Bonus.MiscMod += 3;
    }
}
