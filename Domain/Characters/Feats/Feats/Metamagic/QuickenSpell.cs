using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Metamagic;

public class QuickenSpell(): Domain.Characters.Feats.Properties.Feat("Quicken Spell", FeatType.Metamagic) {
	public override bool CanAcquire() {
		return true;
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}