﻿using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class TowerShieldProficiency: Domain.Characters.Feats.Properties.Feat {
	public TowerShieldProficiency() : base("Tower Shield Proficiency", FeatType.Combat) {
		Prerequisites = [
			new FeatPrerequisite("Shield Proficiency")
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}