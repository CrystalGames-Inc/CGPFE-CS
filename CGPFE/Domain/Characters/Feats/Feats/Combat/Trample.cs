﻿using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class Trample: Domain.Characters.Feats.Properties.Feat {
	public Trample() : base("Trample", FeatType.Combat) {
		Prerequisites = [
			new SkillRankPrerequisite("Ride", 1),
			new FeatPrerequisite("Mounted Combat")
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}