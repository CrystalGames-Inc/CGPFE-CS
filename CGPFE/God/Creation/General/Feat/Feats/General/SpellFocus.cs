namespace CGPFE.God.Creation.General.Feat.Feats.General;

public class SpellFocus(string spellName): Feat("Spell Focus") {

	private string SpellName { get; } = spellName;

	public override bool CanAcquire() {
		return true;
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}