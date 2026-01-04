namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class LightningReflexes() : Characters.Feats.Feat("Lightning Reflexes")
{
    public override bool CanAcquire()
    {
        return true;
    }

    public override void ApplyBenefits()
    {
        PlayerDataManager.Instance.Player.CombatInfo.Reflex += 2;
    }
}