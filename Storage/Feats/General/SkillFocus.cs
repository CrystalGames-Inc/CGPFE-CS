namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class SkillFocus : Characters.Feats.Feat
{

    private string SkillName { get; }

    public SkillFocus() : base("Skill Focus") {
    }

    public SkillFocus(string skillName) : base("Skill Focus") {
        SkillName = skillName;
    }

    public override bool CanAcquire() {
        return true;
    }

    public override void ApplyBenefits() {
        if (PlayerDataManager.Instance.Player.GetMatchingSkill(SkillName).Bonus.Ranks >= 10)
            PlayerDataManager.Instance.Player.GetMatchingSkill(SkillName).Bonus.MiscMod += 6;
        else
            PlayerDataManager.Instance.Player.GetMatchingSkill(SkillName).Bonus.MiscMod += 3;
    }
}