using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;
using Domain.Characters.Player;
using Core.Enums;

namespace Storage.Feats.Combat;

public class GreaterShieldFocus : Feat
{
    public GreaterShieldFocus() : base("Greater Shield Focus", FeatType.Combat) {
        Prerequisites = [
            new FeatPrerequisite("Shield Focus"),
            new FeatPrerequisite("Shield Proficiency"),
            new ValuePrerequisite("Cls", 7, "=="),
            new ValuePrerequisite("Lvl", 8)
        ];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}
