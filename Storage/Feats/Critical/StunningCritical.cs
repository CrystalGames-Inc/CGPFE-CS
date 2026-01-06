using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Player;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;

namespace CGPFE.Storage.Feats.Critical;

public class StunningCritical : Feat
{
    public StunningCritical() : base("Stunning Critical", FeatType.Critical) {
        Prerequisites = [
            new FeatPrerequisite("Critical Focus"),
            new FeatPrerequisite("Staggering Critical"),
            new ValuePrerequisite("Bab", 17)
        ];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}