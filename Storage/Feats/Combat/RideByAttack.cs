using Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;
using Domain.Characters.Player;

namespace Storage.Feats.Combat;

public class RideByAttack : Feat
{
    public RideByAttack() : base("Ride-By Attack", FeatType.Combat) {
        Prerequisites = [
            new SkillRankPrerequisite("Ride", 1),
            new FeatPrerequisite("Mounted Combat")
        ];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}