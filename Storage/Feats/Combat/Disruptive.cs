using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;
using Domain.Characters.Player;
using Core.Enums;

namespace Storage.Feats.Combat;

public class Disruptive : Feat
{
    public Disruptive() : base("Disruptive", FeatType.Combat) {
        Prerequisites = [
            new ValuePrerequisite("Cls", 7, "=="),
            new ValuePrerequisite("Lvl", 6)
        ];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}
