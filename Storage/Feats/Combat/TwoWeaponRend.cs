using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Feat.Prerequisites;
using CGPFE.Domain.Characters.Player;
using CGPFE.Core.Enums;

namespace Storage.Feats.Combat;

public class TwoWeaponRend : Feat
{
    public TwoWeaponRend() : base("Two-Weapon Rend", FeatType.Combat) {
        Prerequisites = [
            new ValuePrerequisite("Dex", 17),
            new FeatPrerequisite("Double Slice"),
            new FeatPrerequisite("Improved Two-Weapon Fighting"),
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
