using CGPFE.Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class PinpointTargeting : Feat
{
    public PinpointTargeting() : base("Pinpoint Targeting", FeatType.Combat) {
        Prerequisites = [
            new ValuePrerequisite("Dex", 19),
            new FeatPrerequisite("Improved Precise Shot"),
            new FeatPrerequisite("Point-Blank Shot"),
            new FeatPrerequisite("Precise Shot"),
            new ValuePrerequisite("Bab", 16)
        ];
    }

    public override bool CanAcquire(Player.Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player.Player player) {
        throw new NotImplementedException();
    }
}