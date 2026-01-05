using Domain.Characters.Feat;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class SkillFocus : Feat
{

    private string SkillName { get; }

    public SkillFocus() : base("Skill Focus") {
    }

    public SkillFocus(string skillName) : base("Skill Focus") {
        SkillName = skillName;
    }

    public override bool CanAcquire(Player.Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player.Player player) {
        if (player.GetMatchingSkill(SkillName).Bonus.Ranks >= 10)
            player.GetMatchingSkill(SkillName).Bonus.MiscMod += 6;
        else
            player.GetMatchingSkill(SkillName).Bonus.MiscMod += 3;
    }
}