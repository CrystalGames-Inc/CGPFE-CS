using CGPFE.Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class GreaterWeaponSpecialization : Feat
{
    public GreaterWeaponSpecialization() : base("Greater Weapon Specialization", FeatType.Combat) {
        Prerequisites = [
            new FeatPrerequisite("Greater Weapon Focus"),
            new FeatPrerequisite("Weapon Specialization"),
            new ValuePrerequisite("Cls", 7, "=="),
            new ValuePrerequisite("Lvl", 12)
        ];
    }

    public override bool CanAcquire(Player.Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player.Player player) {
        throw new NotImplementedException();
    }
}