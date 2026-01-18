using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Feat.Prerequisites;
using CGPFE.Domain.Characters.Player;
using CGPFE.Core.Enums;

namespace Storage.Feats.Combat;

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

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}
