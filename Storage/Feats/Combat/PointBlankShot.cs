using CGPFE.Core.Enums;
using Domain.Characters.Feat;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class PointBlankShot() : Feat("Point-Blank Shot", FeatType.Combat)
{
    public override bool CanAcquire(Player.Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player.Player player) {
        throw new NotImplementedException();
    }
}