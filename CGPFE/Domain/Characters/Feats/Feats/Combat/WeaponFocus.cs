﻿using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class WeaponFocus : Domain.Characters.Feats.Properties.Feat {
	public WeaponFocus() : base("Weapon Focus", FeatType.Combat) {
		Prerequisites = [
			//TODO add specific weapon
			new ValuePrerequisite("Bab", 1)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}