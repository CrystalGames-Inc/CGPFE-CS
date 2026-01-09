using Domain.Characters.Feat;
using Domain.Characters.Player;
using Core.Enums;

namespace Storage.Feats.Combat;

public class ArcaneStrike : Feat
{
    public ArcaneStrike() : base("Arcane Strike", FeatType.Combat) {
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
