using CGPFE.Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class Unseat : Feat
{
    public Unseat() : base("Unseat", FeatType.Combat) {
        Prerequisites = [
            new ValuePrerequisite("Str", 13),
            new SkillRankPrerequisite("Ride", 1),
            new FeatPrerequisite("Mounted Combat"),
            new FeatPrerequisite("Power Attack"),
            new FeatPrerequisite("Improved Bull Rush"),
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