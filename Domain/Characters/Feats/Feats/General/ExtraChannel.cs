namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class ExtraChannel(): Domain.Characters.Feats.Properties.Feat("Extra Channel")
{
    public override bool CanAcquire() {
        return true;
    }

    public override void Benefits() {
        throw new NotImplementedException();
    }
}