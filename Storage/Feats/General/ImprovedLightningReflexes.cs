namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class ImprovedLightningReflexes : Characters.Feats.Feat
{
    public ImprovedLightningReflexes() : base("Improved Lightning Reflexes") {
        Prerequisites = [
            new FeatPrerequisite("Lightning Reflexes")
        ];
    }

    public override bool CanAcquire() {
        return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
    }

    public override void ApplyBenefits() {
        throw new NotImplementedException();
    }
}