﻿using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ImprovedTrip: Domain.Characters.Feats.Properties.Feat {
	public ImprovedTrip() : base("Improved Trip", FeatType.Combat) {
		Prerequisites = [
			new ValuePrerequisite("Int", 13),
			new FeatPrerequisite("Combat Expertise")
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}