﻿using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ImprovedTwoWeaponFighting: Domain.Characters.Feats.Properties.Feat {
	public ImprovedTwoWeaponFighting() : base("Improved Two-Weapon Fighting", FeatType.Combat) {
		Prerequisites = [
			new ValuePrerequisite("Dex", 17),
			new FeatPrerequisite("Two-Weapon Fighting"),
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