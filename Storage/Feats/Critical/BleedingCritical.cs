using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Player;
using Domain.Characters.Feat;

namespace CGPFE.Domain.Characters.Feats.Feats.Critical;

public class BleedingCritical : Feat
{
    public BleedingCritical() : base("Bleeding Critical", FeatType.Critical) {
        Prerequisites = [

        ];
    }

    public override bool CanAcquire(Player.Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player.Player player) {
        throw new NotImplementedException();
    }
}