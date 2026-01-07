using Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;
using Domain.Characters.Player;

namespace Storage.Feats.Combat;

public class GreaterTwoWeaponFighting : Feat
{
    public GreaterTwoWeaponFighting() : base("Greater Two-Weapon Fighting", FeatType.Combat) {
        Prerequisites = [
            new ValuePrerequisite("Dex", 19),
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