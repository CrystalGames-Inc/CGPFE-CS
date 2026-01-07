using Domain.Characters.Feat;
using Domain.Characters.Player;

namespace Storage.Feats.General;

public class IronWill() : Feat("Iron Will")
{
    public override bool CanAcquire(Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player player) {
        player.CombatInfo.Will += 2;
    }
}