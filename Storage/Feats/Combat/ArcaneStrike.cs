using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Player;

namespace CGPFE.Storage.Feats.Combat;

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