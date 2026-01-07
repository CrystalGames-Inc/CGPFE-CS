using Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;
using Domain.Characters.Player;

namespace Storage.Feats.Combat;

public class GreaterTrip : Feat
{
    public GreaterTrip() : base("Greater Trip", FeatType.Combat) {
        Prerequisites = [
            new FeatPrerequisite("Combat Expertise"),
            new FeatPrerequisite("Improved Trip"),
            new ValuePrerequisite("Bab", 6),
            new ValuePrerequisite("Int", 13)
        ];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}