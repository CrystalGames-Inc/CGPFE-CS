using Domain.Characters.Feat;
using Domain.Characters.Player;

namespace Storage.Feats.General;

public class Run() : Feat("Run")
{
    public override bool CanAcquire(Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}