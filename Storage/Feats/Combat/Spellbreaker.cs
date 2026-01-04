using CGPFE.Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class Spellbreaker : Feat
{
    public Spellbreaker() : base("Spellbreaker", FeatType.Combat) {
        Prerequisites = [
            new FeatPrerequisite("Disruptive"),
            new ValuePrerequisite("Cls", 7),
            new ValuePrerequisite("Lvl", 10)
        ];
    }

    public override bool CanAcquire(Player.Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player.Player player) {
        throw new NotImplementedException();
    }
}