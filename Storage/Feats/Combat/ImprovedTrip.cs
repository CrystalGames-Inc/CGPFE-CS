using CGPFE.Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ImprovedTrip : Feat
{
    public ImprovedTrip() : base("Improved Trip", FeatType.Combat) {
        Prerequisites = [
            new ValuePrerequisite("Int", 13),
            new FeatPrerequisite("Combat Expertise")
        ];
    }

    public override bool CanAcquire(Player.Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player.Player player) {
        throw new NotImplementedException();
    }
}