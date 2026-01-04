namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class ImprovedGreatFortitude : Characters.Feats.Feat
{
    public ImprovedGreatFortitude() : base("Improved Great Fortitude")
    {
        Prerequisites = [
            new FeatPrerequisite("Great Fortitude")
        ];
    }

    public override bool CanAcquire()
    {
        return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
    }

    public override void ApplyBenefits()
    {
        throw new NotImplementedException();
    }
}