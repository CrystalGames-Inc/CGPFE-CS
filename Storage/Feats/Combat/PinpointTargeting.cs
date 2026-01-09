using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Feat.Prerequisites;
using CGPFE.Domain.Characters.Player;
using CGPFE.Core.Enums;

namespace Storage.Feats.Combat;

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

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}
