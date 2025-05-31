﻿using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class RapidShot: Domain.Characters.Feats.Properties.Feat {
	public RapidShot() : base("Rapid Shot", FeatType.Combat) {
		Prerequisites = [
			new ValuePrerequisite("Dex", 13),
			new FeatPrerequisite("Point-Blank Shot")
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}