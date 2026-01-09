using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;
using Domain.Characters.Player;
using Core.Enums;

namespace Storage.Feats.Combat;

public class GreaterBullRush : Feat
{
    public GreaterBullRush() : base("Greater Bull Rush", FeatType.Combat) {
        Prerequisites = [
            new FeatPrerequisite("Improved Bull Rush"),
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
