using Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Player;

namespace Storage.Feats.Combat;

public class ImprovedInitiative() : Feat("Improved Initiative", FeatType.Combat)
{
    public override bool CanAcquire(Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player player) {
        player.CombatInfo.InitMod += 4;
    }
}