using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Player;
using Domain.Characters.Feat;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class CatchOffGuard() : Feat("Catch Off-Guard", FeatType.Combat)
{
    public override bool CanAcquire(Player.Player player)
    {
        return true;
    }

    public override void ApplyBenefits(ref Player.Player player)
    {
        throw new NotImplementedException();
    }
}