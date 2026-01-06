using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Player;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;

namespace CGPFE.Storage.Feats.Combat;

public class ShieldMaster : Feat
{
    public ShieldMaster() : base("Shield Master", FeatType.Combat) {
        Prerequisites = [
            new FeatPrerequisite("Improved Shield Bash"),
            new FeatPrerequisite("Shield Proficiency"),
            new FeatPrerequisite("Shield Slam"),
            new FeatPrerequisite("Two-Weapon Fighting"),
            new ValuePrerequisite("Bab", 11)
        ];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}