using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Feat.Prerequisites;
using CGPFE.Domain.Characters.Player;
using CGPFE.Core.Enums;

namespace Storage.Feats.Combat;

public class Spellbreaker : Feat
{
    public Spellbreaker() : base("Spellbreaker", FeatType.Combat) {
        Prerequisites = [
            new FeatPrerequisite("Disruptive"),
            new ValuePrerequisite("Cls", 7),
            new ValuePrerequisite("Lvl", 10)
        ];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}
