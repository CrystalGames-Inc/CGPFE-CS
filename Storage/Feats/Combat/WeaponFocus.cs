using CGPFE.Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class WeaponFocus : Feat
{
    public WeaponFocus() : base("Weapon Focus", FeatType.Combat) {
        Prerequisites = [
			//TODO add specific weapon
			new ValuePrerequisite("Bab", 1)
        ];
    }

    public override bool CanAcquire(Player.Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player.Player player) {
        throw new NotImplementedException();
    }
}