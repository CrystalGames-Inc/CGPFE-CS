using Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;
using Domain.Characters.Player;

namespace Storage.Feats.Combat;

public class ImprovedFeint : Feat
{
    public ImprovedFeint() : base("Improved Feint", FeatType.Combat) {
        Prerequisites = [
            new ValuePrerequisite("Int", 13),
            new FeatPrerequisite("Combat Expertise")
        ];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}