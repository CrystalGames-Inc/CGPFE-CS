using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Player;
using Domain.Characters.Feat;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ArcaneStrike : Feat
{
    public ArcaneStrike() : base("Arcane Strike", FeatType.Combat)
    {
        Prerequisites = [
        ];
    }

    public override bool CanAcquire(Player.Player player)
    {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player.Player player)
    {
        throw new NotImplementedException();
    }
}