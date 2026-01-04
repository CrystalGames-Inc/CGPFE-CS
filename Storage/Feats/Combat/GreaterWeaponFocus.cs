using CGPFE.Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class GreaterWeaponFocus : Feat
{
    public GreaterWeaponFocus() : base("Greater Weapon Focus", FeatType.Combat) {
        Prerequisites = [
            new FeatPrerequisite("Weapon Focus"),
            new ValuePrerequisite("Cls", 7, "=="),
            new ValuePrerequisite("Lvl", 8)
        ];
    }

    public override bool CanAcquire(Player.Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player.Player player) {
        throw new NotImplementedException();
    }
}