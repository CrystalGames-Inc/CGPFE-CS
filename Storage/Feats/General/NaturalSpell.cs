using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;
using Domain.Characters.Player;

namespace Storage.Feats.General;

public class NaturalSpell : Feat
{
    public NaturalSpell() : base("Natural Spell") {
        Prerequisites = [
            new ValuePrerequisite("Wis", 13),
			//TODO Add class feature prerequisite
		];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}
