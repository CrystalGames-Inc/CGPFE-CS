﻿using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class ArcaneArmorMastery : Feat {

	public ArcaneArmorMastery() : base("Arcane Armor Mastery", FeatType.Combat) {
		Prerequisites = [
			new FeatPrerequisite("Arcane Armor Training"),
			new FeatPrerequisite("Medium Armor Proficiency"),
			new ValuePrerequisite("Lvl", 7)
		];
	}
	
	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}