namespace CGPFE.God.Creation.General.Feat.Feats.General;

public class SpellFocus: Feat {

	private string SpellName { get; }

	public SpellFocus() : base("Spell Focus") {
		
	}

	public SpellFocus(string spellName) : base("Spell Focus") {
		SpellName = spellName;
	}

	public override bool CanAcquire() {
		return true;
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}