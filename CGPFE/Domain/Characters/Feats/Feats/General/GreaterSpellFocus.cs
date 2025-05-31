﻿using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class GreaterSpellFocus: Domain.Characters.Feats.Properties.Feat {
	public GreaterSpellFocus() : base("Greater Spell Focus") {
		Prerequisites = [
			new FeatPrerequisite("Spell Focus")
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}