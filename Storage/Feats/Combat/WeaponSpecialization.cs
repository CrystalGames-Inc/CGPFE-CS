using Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;
using Domain.Characters.Player;

namespace Storage.Feats.Combat;

public class WeaponSpecialization : Feat
{
    public WeaponSpecialization() : base("Weapon Specialization", FeatType.Combat) {
        Prerequisites = [
            new FeatPrerequisite("Weapon Focus"),
            new ValuePrerequisite("Cls", 7),
            new ValuePrerequisite("Lvl", 4)
        ];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}