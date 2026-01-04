namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class AcrobaticSteps : Characters.Feats.Feat
{
    public AcrobaticSteps() : base("Acrobatic Steps")
    {
        Prerequisites = [
            new ValuePrerequisite("Dex", 15),
            new FeatPrerequisite("Nimble Moves")
        ];
    }

    public override bool CanAcquire()
    {
        return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
    }

    public override void ApplyBenefits()
    {
        // TODO add benefits
    }
}