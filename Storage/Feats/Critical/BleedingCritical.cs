using Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Player;

namespace Storage.Feats.Critical;

public class BleedingCritical : Feat
{
    public BleedingCritical() : base("Bleeding Critical", FeatType.Critical) {
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