using Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;
using Domain.Characters.Player;

namespace Storage.Feats.Combat;

public class ImprovisedWeaponMastery : Feat
{
    public ImprovisedWeaponMastery() : base("Improvised Weapon Mastery", FeatType.Combat) {
        Prerequisites = [
            new FeatPrerequisite("Catch Off-Guard"),
            new FeatPrerequisite("Throw Anything"),
            new ValuePrerequisite("Bab", 8)
        ];
    }

    public override bool CanAcquire(Player player) {
        return (Prerequisites[0].IsSatisfiedBy(player) || Prerequisites[1].IsSatisfiedBy(player)) && Prerequisites.Last().IsSatisfiedBy(player);
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}