using Domain.Characters.Feat;
using Domain.Characters.Player;

namespace Storage.Feats.General;

public class LightningReflexes() : Feat("Lightning Reflexes")
{
    public override bool CanAcquire(Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player player) {
        player.CombatInfo.Reflex += 2;
    }
}
