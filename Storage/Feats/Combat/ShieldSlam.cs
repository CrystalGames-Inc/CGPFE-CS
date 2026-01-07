using Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;
using Domain.Characters.Player;

namespace Storage.Feats.Combat;

public class ShieldSlam : Feat
{
    public ShieldSlam() : base("Shield Slam", FeatType.Combat) {
        Prerequisites = [
            new FeatPrerequisite("Improved Shield Bash"),
            new FeatPrerequisite("Shield Proficiency"),
            new FeatPrerequisite("Two-Weapon Fighting"),
            new ValuePrerequisite("Bab", 6)
        ];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}