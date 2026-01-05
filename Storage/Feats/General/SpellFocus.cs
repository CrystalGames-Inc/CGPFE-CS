using Domain.Characters.Feat;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class SpellFocus : Feat
{

    private string SpellName { get; }

    public SpellFocus() : base("Spell Focus") {

    }

    public SpellFocus(string spellName) : base("Spell Focus") {
        SpellName = spellName;
    }

    public override bool CanAcquire(Player.Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player.Player player) {
        throw new NotImplementedException();
    }
}