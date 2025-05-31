﻿using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class AnimalAffinity(): Domain.Characters.Feats.Properties.Feat("Animal Affinity") {
	public override bool CanAcquire() {
		return true;
	}

	public override void Benefits() {
		PlayerDataManager.Instance.Player.GetMatchingSkill("Handle Animal").Bonus.SetMiscMod(
			PlayerDataManager.Instance.Player.GetMatchingSkill("Handle Animal").Bonus.Ranks >= 10 ? 4 : 2);

		PlayerDataManager.Instance.Player.GetMatchingSkill("Ride").Bonus.SetMiscMod(
			PlayerDataManager.Instance.Player.GetMatchingSkill("Ride").Bonus.Ranks >= 10 ? 4 : 2);
	}
}