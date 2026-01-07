using Domain.Characters.Feat;
using Domain.Characters.Player;

namespace Storage.Feats.General;

public class AlignmentChannel() : Feat("Alignment Channel")
{
    public override bool CanAcquire(Player player) {
        throw new NotImplementedException();
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}