using CGPFE.Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class SpiritedCharge : Feat
{
    public SpiritedCharge() : base("Spirited Charge", FeatType.Combat) {
        Prerequisites = [
            new SkillRankPrerequisite("Ride", 1),
            new FeatPrerequisite("Mounted Combat"),
            new FeatPrerequisite("Ride-By Attack")
        ];
    }

    public override bool CanAcquire(Player.Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player.Player player) {
        throw new NotImplementedException();
    }
}