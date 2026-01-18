using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Feat.Prerequisites;
using CGPFE.Domain.Characters.Player;
using CGPFE.Core.Enums;

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
