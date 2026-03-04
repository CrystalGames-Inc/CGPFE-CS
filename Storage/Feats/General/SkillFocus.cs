using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Player;
using CGPFE.Storage.Skills;

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
        player.GetMatchingSkill(SkillName, [..Skills.skills]).Bonus.
            ChangeMiscMod(player.GetMatchingSkill(SkillName, [..Skills.skills]).Bonus.Ranks >= 10 ? 6 : 3);
    }
}
