using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Player;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;

namespace CGPFE.Storage.Feats.Combat;

public class ImprovedDisarm : Feat
{
    public ImprovedDisarm() : base("Improved Disarm", FeatType.Combat) {
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