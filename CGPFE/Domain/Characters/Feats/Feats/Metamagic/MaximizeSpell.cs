using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Metamagic;

public class MaximizeSpell(): Domain.Characters.Feats.Properties.Feat("Maximize Spell", FeatType.Metamagic) {
	public override bool CanAcquire() {
		return true;
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}