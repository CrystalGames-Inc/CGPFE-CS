namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class MasterCraftsman : Characters.Feats.Feat
{
    public MasterCraftsman() : base("Master Craftsman") {
        Prerequisites = [
            new SkillRankPrerequisite("Craft", 5),
            new SkillRankPrerequisite("Profession", 5)
        ];
    }

    public override bool CanAcquire() {
        return Prerequisites[0].IsSatisfiedBy(PlayerDataManager.Instance.Player) || Prerequisites[1].IsSatisfiedBy(PlayerDataManager.Instance.Player);
    }

    public override void ApplyBenefits() {
        throw new NotImplementedException();
    }
}