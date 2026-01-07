using Domain.Characters.Feat;
using Domain.Characters.Player;

namespace Storage.Feats.General;

public class ExtraLayOnHands : Feat
{
    public ExtraLayOnHands() : base("Extra Lay On Hands") {
        Prerequisites = [

        ];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}