﻿using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Critical;

public class StaggeringCritical: Domain.Characters.Feats.Properties.Feat {
	public StaggeringCritical() : base("Staggering Critical", FeatType.Critical) {
		Prerequisites = [
			new FeatPrerequisite("Critical Focus"),
			new ValuePrerequisite("Bab", 3)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}