﻿using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class WindStance: Domain.Characters.Feats.Properties.Feat {
	public WindStance() : base("Wind Stance") {
		Prerequisites = [
			new ValuePrerequisite("Dex", 15),
			new FeatPrerequisite("Dodge"),
			new ValuePrerequisite("Bab", 6)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}