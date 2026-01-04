namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class SpellFocus : Characters.Feats.Feat
{

    private string SpellName { get; }

    public SpellFocus() : base("Spell Focus") {

    }

    public SpellFocus(string spellName) : base("Spell Focus") {
        SpellName = spellName;
    }

    public override bool CanAcquire() {
        return true;
    }

    public override void ApplyBenefits() {
        throw new NotImplementedException();
    }
}