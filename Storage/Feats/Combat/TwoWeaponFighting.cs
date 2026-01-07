using Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;
using Domain.Characters.Player;

namespace Storage.Feats.Combat;

public class TwoWeaponFighting : Feat
{
    public TwoWeaponFighting() : base("Two-Weapon Fighting", FeatType.Combat) {
        Prerequisites = [
            new ValuePrerequisite("Dex", 15)
        ];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}