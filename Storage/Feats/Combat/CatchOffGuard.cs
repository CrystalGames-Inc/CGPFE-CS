using Domain.Characters.Feat;
using Domain.Characters.Player;
using Core.Enums;

namespace Storage.Feats.Combat;

public class CatchOffGuard() : Feat("Catch Off-Guard", FeatType.Combat)
{
    public override bool CanAcquire(Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}
