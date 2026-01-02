namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class Fleet(): Domain.Characters.Feats.Properties.Feat("Fleet")
{
    public override bool CanAcquire() {
        return true;
    }

    public override void Benefits() {
        throw new NotImplementedException();
    }
}