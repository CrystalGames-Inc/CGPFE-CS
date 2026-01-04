using CGPFE.Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class GreaterGrapple : Feat
{
    public GreaterGrapple() : base("Greater Grapple", FeatType.Combat) {
        Prerequisites = [
            new FeatPrerequisite("Improved Grapple"),
            new FeatPrerequisite("Improved Unarmed Strike"),
            new ValuePrerequisite("Bab", 6),
            new ValuePrerequisite("Dex", 13)
        ];
    }

    public override bool CanAcquire(Player.Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player.Player player) {
        throw new NotImplementedException();
    }
}