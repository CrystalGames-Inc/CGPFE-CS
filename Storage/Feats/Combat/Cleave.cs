using Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;
using Domain.Characters.Player;

namespace Storage.Feats.Combat;

public class Cleave : Feat
{
    public Cleave() : base("Cleave", FeatType.Combat) {
        Prerequisites = [
            new ValuePrerequisite("Str", 13),
            new FeatPrerequisite("Power Attack"),
            new ValuePrerequisite("Bab", 1)
        ];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}