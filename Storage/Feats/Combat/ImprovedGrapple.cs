using CGPFE.Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ImprovedGrapple : Feat
{
    public ImprovedGrapple() : base("Improved Grapple", FeatType.Combat) {
        Prerequisites = [
            new ValuePrerequisite("Dex", 13),
            new FeatPrerequisite("Improved Unarmed Strike")
        ];
    }

    public override bool CanAcquire(Player.Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player.Player player) {
        throw new NotImplementedException();
    }
}