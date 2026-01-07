using Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;
using Domain.Characters.Player;

namespace Storage.Feats.Combat;

public class WeaponFocus : Feat
{
    public WeaponFocus() : base("Weapon Focus", FeatType.Combat) {
        Prerequisites = [
			//TODO add specific weapon
			new ValuePrerequisite("Bab", 1)
        ];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}