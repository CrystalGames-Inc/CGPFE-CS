namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class SpellFocus: Domain.Characters.Feats.Properties.Feat {

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