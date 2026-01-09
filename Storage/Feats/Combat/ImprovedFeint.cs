using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Feat.Prerequisites;
using CGPFE.Domain.Characters.Player;
using CGPFE.Core.Enums;

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
