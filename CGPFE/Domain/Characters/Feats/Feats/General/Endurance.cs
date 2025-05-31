namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class Endurance(): Domain.Characters.Feats.Properties.Feat("Endurance")
{
    public override bool CanAcquire() {
        return true;
    }

    public override void Benefits() {
        throw new NotImplementedException();
    }
}