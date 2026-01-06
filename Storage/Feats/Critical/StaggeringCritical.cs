using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Player;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;

namespace CGPFE.Storage.Feats.Critical;

public class StaggeringCritical : Feat
{
    public StaggeringCritical() : base("Staggering Critical", FeatType.Critical) {
        Prerequisites = [
            new FeatPrerequisite("Critical Focus"),
            new ValuePrerequisite("Bab", 3)
        ];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}