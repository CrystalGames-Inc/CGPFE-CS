using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;
using Domain.Characters.Player;
using Core.Enums;

namespace Storage.Feats.Combat;

public class GreaterVitalStrike : Feat
{
    public GreaterVitalStrike() : base("Greater Vital Strike", FeatType.Combat) {
        Prerequisites = [
            new FeatPrerequisite("Improved Vital Strike"),
            new FeatPrerequisite("Vital Strike"),
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
