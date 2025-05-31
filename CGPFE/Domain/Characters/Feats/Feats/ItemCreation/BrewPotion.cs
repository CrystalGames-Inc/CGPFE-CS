﻿using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.ItemCreation;

public class BrewPotion: Domain.Characters.Feats.Properties.Feat {
	public BrewPotion() : base("Brew Potion", FeatType.ItemCreation) {
		Prerequisites = [
			new ValuePrerequisite("Lvl", 3)	
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player)); 
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}