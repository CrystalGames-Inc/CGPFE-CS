namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class Fleet(): Characters.Feats.Feat("Fleet")
{
    public override bool CanAcquire() {
        return true;
    }

    public override void ApplyBenefits() {
        throw new NotImplementedException();
    }
}