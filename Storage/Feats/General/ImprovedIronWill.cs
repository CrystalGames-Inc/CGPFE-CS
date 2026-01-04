namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class ImprovedIronWill : Characters.Feats.Feat
{
    public ImprovedIronWill() : base("Improved Iron Will") {
        Prerequisites = [
            new FeatPrerequisite("Iron Will")
        ];
    }

    public override bool CanAcquire() {
        return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
    }

    public override void ApplyBenefits() {
        throw new NotImplementedException();
    }
}