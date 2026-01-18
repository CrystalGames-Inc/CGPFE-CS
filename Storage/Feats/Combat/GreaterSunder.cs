using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Feat.Prerequisites;
using CGPFE.Domain.Characters.Player;
using CGPFE.Core.Enums;

namespace Storage.Feats.Combat;

public class GreaterSunder : Feat
{
    public GreaterSunder() : base("Greater Sunder", FeatType.Combat) {
        Prerequisites = [
            new FeatPrerequisite("Improved Sunder"),
            new FeatPrerequisite("Power Attack"),
            new ValuePrerequisite("Bab", 6),
            new ValuePrerequisite("Str", 13)
        ];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}
