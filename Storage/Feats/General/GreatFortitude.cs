using Domain.Characters.Feat;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class GreatFortitude() : Feat("Great Fortitude")
{
    public override bool CanAcquire(Player.Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player.Player player) {
        player.CombatInfo.Fortitude += 2;
    }
}