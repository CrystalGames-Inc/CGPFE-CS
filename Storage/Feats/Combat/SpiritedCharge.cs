using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Feat.Prerequisites;
using CGPFE.Domain.Characters.Player;
using CGPFE.Core.Enums;

namespace Storage.Feats.Combat;

public class SpiritedCharge : Feat
{
    public SpiritedCharge() : base("Spirited Charge", FeatType.Combat) {
        Prerequisites = [
            new SkillRankPrerequisite("Ride", 1),
            new FeatPrerequisite("Mounted Combat"),
            new FeatPrerequisite("Ride-By Attack")
        ];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}
