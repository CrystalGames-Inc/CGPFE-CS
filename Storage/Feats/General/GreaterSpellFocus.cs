using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Feat.Prerequisites;
using CGPFE.Domain.Characters.Player;

namespace Storage.Feats.General;

public class GreaterSpellFocus : Feat
{
    public GreaterSpellFocus() : base("Greater Spell Focus") {
        Prerequisites = [
            new FeatPrerequisite("Spell Focus")
        ];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}
