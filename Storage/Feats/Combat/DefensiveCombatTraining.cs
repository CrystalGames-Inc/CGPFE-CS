using Domain.Characters.Feat;
using Domain.Characters.Player;
using Core.Enums;

namespace Storage.Feats.Combat;

public class DefensiveCombatTraining() : Feat("Defensive Combat Training", FeatType.Combat)
{
    public override bool CanAcquire(Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}
