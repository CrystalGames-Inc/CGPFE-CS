using Domain.Characters.Feat;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class ImprovedCounterspell() : Feat("Improved Counterspell")
{
    public override bool CanAcquire(Player.Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player.Player player) {
        throw new NotImplementedException();
    }
}