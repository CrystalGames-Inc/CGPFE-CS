using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Feat.Prerequisites;
using CGPFE.Domain.Characters.Player;

namespace Storage.Feats.General;

public class SpellMastery : Feat
{
    public SpellMastery() : base("Spell Mastery") {
        Prerequisites = [
            new ValuePrerequisite("Cls", 17, "=="),
            new ValuePrerequisite("Lvl", 1)
        ];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}
