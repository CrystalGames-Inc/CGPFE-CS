using CGPFE.Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;

namespace CGPFE.Domain.Characters.Feats.Feats.Critical;

public class StaggeringCritical : Feat
{
    public StaggeringCritical() : base("Staggering Critical", FeatType.Critical) {
        Prerequisites = [
            new FeatPrerequisite("Critical Focus"),
            new ValuePrerequisite("Bab", 3)
        ];
    }

    public override bool CanAcquire(Player.Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player.Player player) {
        throw new NotImplementedException();
    }
}