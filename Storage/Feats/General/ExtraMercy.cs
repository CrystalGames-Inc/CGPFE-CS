using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Player;

namespace Storage.Feats.General;

public class ExtraMercy : Feat
{
    public ExtraMercy() : base("Extra Mercy") {
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
