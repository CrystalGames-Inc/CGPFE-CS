using Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;
using Domain.Characters.Player;

namespace Storage.Feats.Combat;

public class GreatCleave : Feat
{
    public GreatCleave() : base("Great Cleave", FeatType.Combat) {
        Prerequisites = [
            new ValuePrerequisite("Str", 13),
            new FeatPrerequisite("Cleave"),
            new FeatPrerequisite("Power Attack"),
            new ValuePrerequisite("Bab", 4)
        ];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}