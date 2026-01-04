namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class GreatFortitude() : Characters.Feats.Feat("Great Fortitude")
{
    public override bool CanAcquire() {
        return true;
    }

    public override void ApplyBenefits() {
        PlayerDataManager.Instance.Player.CombatInfo.Fortitude += 2;
    }
}