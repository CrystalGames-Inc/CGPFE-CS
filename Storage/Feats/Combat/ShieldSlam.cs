using CGPFE.Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

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

    public override bool CanAcquire(Player.Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player.Player player) {
        throw new NotImplementedException();
    }
}