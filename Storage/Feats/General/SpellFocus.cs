using Domain.Characters.Feat;
using Domain.Characters.Player;

namespace Storage.Feats.General;

public class SpellFocus : Feat
{

    private string SpellName { get; }

    public SpellFocus() : base("Spell Focus") {

    }

    public SpellFocus(string spellName) : base("Spell Focus") {
        SpellName = spellName;
    }

    public override bool CanAcquire(Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}
