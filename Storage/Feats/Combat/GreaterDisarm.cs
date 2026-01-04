using CGPFE.Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class GreaterDisarm : Feat
{
    public GreaterDisarm() : base("Greater Disarm", FeatType.Combat) {
        Prerequisites = [
            new FeatPrerequisite("Combat Expertise"),
            new FeatPrerequisite("Improved Disarm"),
            new ValuePrerequisite("Bab", 6),
            new ValuePrerequisite("Int", 13)
        ];
    }

    public override bool CanAcquire(Player.Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player.Player player) {
        throw new NotImplementedException();
    }
}