using CGPFE.World.Settlement.Properties;

namespace CGPFE.World.Settlement;

public class Settlement {

	#region Properties
	
	public Info Info { get; set; }
	public Modifiers Modifiers { get; set; }
	public Marketplace Marketplace { get; set; }
	public Location[] Locations { get; set; }

	#endregion

	public Settlement(Info info) {
		Info = info;
	}

	#region Checkers
	
	public bool HasQuality(Quality quality) {
		foreach (Quality q in Modifiers.Qualities){
			if (q == quality)
				return true;
		}
		return false;
	}
	
	public bool HasDisadvantage(Disadvantage disadvantage) {
		foreach (Disadvantage d in Modifiers.Disadvantages) {
			if (d == disadvantage)
				return true;
		}
		return false;
	}
	
	#endregion
	
	#region Data Calculations

	public void CalculateSettlementData() {
		CalculateDanger();
		CalculateQualitySize();
		CalculateBaseValue();
		CalculatePurchaseLimit();
		CalculateSpellcasting();
		CalculateModifiers();
	}

	private void CalculateDanger() {
		switch (Info.Type) {
			case Type.THORPE:
				Info.Danger = -4 ;
				break;
			case Type.HAMLET:
				Info.Danger = -5 ;
				break;
			case Type.VILLAGE:
				Info.Danger = 0;
				break;
			case Type.S_TOWN:
				Info.Danger = 0;
				break;
			case Type.L_TOWN:
				Info.Danger = 5;
				break;
			case Type.S_CITY:
				Info.Danger = 5 ;
				break;
			case Type.L_CITY:
				Info.Danger = 10;
				break;
			case Type.METROPOLIS:
				Info.Danger = 10;
				break;
		}
	}

	private void CalculateQualitySize() {
		Modifiers.Qualities = Info.Type switch {
			Type.THORPE => new Quality[1],
			Type.HAMLET => new Quality[1],
			Type.VILLAGE => new Quality[2],
			Type.S_TOWN => new Quality[2],
			Type.L_TOWN => new Quality[3],
			Type.S_CITY => new Quality[4],
			Type.L_CITY => new Quality[5],
			Type.METROPOLIS => new Quality[6],
			_ => Modifiers.Qualities
		};
	}

	private void CalculateBaseValue() {
		Marketplace.BaseValue = Info.Type switch {
			Type.THORPE => 50,
			Type.HAMLET => 200,
			Type.VILLAGE => 500,
			Type.S_TOWN => 1000,
			Type.L_TOWN => 2000,
			Type.S_CITY => 4000,
			Type.L_CITY => 8000,
			Type.METROPOLIS => 16000,
			_ => Marketplace.BaseValue
		};
	}

	private void CalculatePurchaseLimit() {
		Marketplace.PurchaseLimit = Info.Type switch {
			Type.THORPE => 500,
			Type.HAMLET => 1000,
			Type.VILLAGE => 2500,
			Type.S_TOWN => 5000,
			Type.L_TOWN => 10000,
			Type.S_CITY => 25000,
			Type.L_CITY => 50000,
			Type.METROPOLIS => 100000,
			_ => Marketplace.PurchaseLimit
		};
	}

	private void CalculateSpellcasting() {
		Marketplace.Spellcasting = Info.Type switch {
			Type.THORPE => 1,
			Type.HAMLET => 2,
			Type.VILLAGE => 3,
			Type.S_TOWN => 4,
			Type.L_TOWN => 5,
			Type.S_CITY => 6,
			Type.L_CITY => 7,
			Type.METROPOLIS => 8,
			_ => Marketplace.Spellcasting
		};
	}

	private void CalculateModifiers() {
		CalculateGovernmentModifiers();
		CalculateQualityModifiers();
		CalculateDisadvantageModifiers();
	}

	private void CalculateGovernmentModifiers() {
		switch (Info.Government) {
			case Government.COLONIAL:
				Modifiers.Corruption += 2;
				Modifiers.Economy += 1;
				Modifiers.Law += 1;
			break;
			case Government.COUNCIL:
				Modifiers.Society += 4;
				Modifiers.Law -= 2;
				Modifiers.Lore -= 2;
			break;
			case Government.DYNASTY:
				Modifiers.Corruption += 1;
				Modifiers.Law += 1;
				Modifiers.Society -= 2;
			break;
			case Government.MAGICAL:
				Modifiers.Lore += 2;
				Modifiers.Corruption -= 2;
				Modifiers.Society -= 2;
				Marketplace.Spellcasting -= 1;
			break;
			case Government.MILITARY:
				Modifiers.Law += 3;
				Modifiers.Corruption -= 1;
				Modifiers.Society -= 1; 
			break;
			case Government.OVERLORD:
				Modifiers.Corruption += 2;
				Modifiers.Law += 2;
				Modifiers.Crime -= 2;
				Modifiers.Society -= 2;
			break;
			case Government.SECRET_SYNDICATE:
				Modifiers.Corruption += 2;
				Modifiers.Economy += 2;
				Modifiers.Crime += 2;
				Modifiers.Law -= 6;
			break;
			case Government.PLUTOCRACY:
				Modifiers.Corruption += 2;
				Modifiers.Crime += 2;
				Modifiers.Economy += 3;
				Modifiers.Society -= 2;
			break;
			case Government.UTOPIA:
				Modifiers.Society += 2;
				Modifiers.Lore += 1;
				Modifiers.Corruption -= 2;
				Modifiers.Crime -= 1;
			break;
		}
	}

	private void CalculateQualityModifiers() {
		foreach (Quality q in Modifiers.Qualities){
			switch (q) {
				case Quality.ABUNDANT:
					Modifiers.Economy += 1;
				break;
				case Quality.ABSTINENT:
					Modifiers.Corruption += 2;
					Modifiers.Law += 1;
					Modifiers.Society -= 2;
					break;
				case Quality.ACADEMIC:
					Modifiers.Lore += 1; 
					Marketplace.Spellcasting += 1;
				break;
				case Quality.ADVENTURESITE:
					Modifiers.Society += 2;
					Marketplace.PurchaseLimit *= 1.5;
				break;
				case Quality.ANIMAL_POLYGLOT:
					Modifiers.Economy -= 1;
					Modifiers.Lore += 1;
					Marketplace.Spellcasting += 1;
				break;
				case Quality.ARTIFACTGATHERER: 
					Modifiers.Economy += 2;
					Marketplace.BaseValue /= 2;
				break;
				case Quality.ARTISTCOLONY:
					Modifiers.Economy += 1;
					Modifiers.Society += 1;
				break;
				case Quality.ASYLUM:
					Modifiers.Lore += 1;
					Modifiers.Society -= 2;
				break;
				case Quality.BROADMINDED:
					Modifiers.Lore += 1;
					Modifiers.Society += 1;
				break;
				case Quality.DEADCITY:
					Modifiers.Economy -= 2;
					Modifiers.Lore += 2;
					Modifiers.Law += 1;
				break;
				case Quality.CRUELWATCH:
					Modifiers.Corruption += 1;
					Modifiers.Law = 2;
					Modifiers.Crime -= 3;
					Modifiers.Society -= 2;
				break;
				case Quality.CULTURED:
					Modifiers.Society += 1;
					Modifiers.Law -= 1;
				break;
				case Quality.DARKVISION:
					Modifiers.Economy += 1;
					Modifiers.Crime -= 1;
				break;
				case Quality.DECADENT:
					Modifiers.Corruption += 1;
					Modifiers.Crime += 1;
					Modifiers.Economy += 1;
					Modifiers.Society += 1;
					Info.Danger += 10;
					Marketplace.PurchaseLimit *= 1.25;
				break;
				case Quality.DEEPTRADITIONS:
					Modifiers.Law += 2;
					Modifiers.Crime -= 2;
					Modifiers.Society -= 2;
				break;
				case Quality.DEFENSIBLE:
					Modifiers.Corruption += 1;
					Modifiers.Crime += 1;
					Modifiers.Economy += 2;
					Modifiers.Society -= 1;
				break;
				case Quality.DEFIANT:
					Modifiers.Society += 1;
					Modifiers.Law -= 1;
				break;
				case Quality.ELDRITCH:
					Modifiers.Lore += 2;
					Info.Danger += 13;
					Marketplace.Spellcasting += 2;
				break;
				case Quality.FAMEDBREEDERS:
					Modifiers.Economy += 1;
					Marketplace.BaseValue *= 1.2;
					Marketplace.PurchaseLimit *= 1.2;
				break;
				case Quality.FINANCIALCENTER:
					Modifiers.Economy += 2;
					Modifiers.Law += 1;
					Marketplace.BaseValue *= 1.4;
					Marketplace.PurchaseLimit *= 1.4;
				break;
				case Quality.FREECITY:
					Modifiers.Crime += 2;
					Info.Danger += 5;
					Modifiers.Law -= 2;
				break;
				case Quality.GAMBLING:
					Modifiers.Crime += 2;
					Modifiers.Corruption += 2;
					Modifiers.Economy += 2;
					Modifiers.Law -= 1;
					Marketplace.PurchaseLimit *= 1.1;
				break;
				case Quality.GODRULED:
					Modifiers.Corruption -= 2;
					Modifiers.Society -= 2;
				break;
				case Quality.GOODROADS:
					Modifiers.Economy += 2;
				break;
				case Quality.GUILDS:
					Modifiers.Corruption += 1;
					Modifiers.Economy += 1;
					Modifiers.Lore -= 1;
				break;
				case Quality.HOLYSITE:
					Modifiers.Corruption -= 2;
					Marketplace.Spellcasting += 2;
				break;
				case Quality.INSULAR:
					Modifiers.Law += 1;
					Modifiers.Crime -= 1;
				break;
				case Quality.LEGENDARYMARKETPLACE:
					if (Info.Type == Type.METROPOLIS) {
						Marketplace.BaseValue *= 2;
						Marketplace.PurchaseLimit *= 2;
					}

					Modifiers.Economy += 2;
					Modifiers.Crime += 2;
				break;
				case Quality.LIVINGFOREST:
					Modifiers.Lore += 1;
					Modifiers.Society += 2;
					Modifiers.Crime -= 2;
					Modifiers.Economy -= 4;
					Marketplace.Spellcasting += 4;
				break;
				case Quality.MAGICALLYATTUNED:
					Marketplace.BaseValue *= 1.2;
					Marketplace.PurchaseLimit *= 1.2;
					Marketplace.Spellcasting += 2;
				break;
				case Quality.MAGICALPOLYGLOT:
					Modifiers.Economy += 1;
					Modifiers.Lore += 1;
					Modifiers.Society += 1;
				break;
				case Quality.MAJESTIC:
					Marketplace.Spellcasting += 1;
				break;
				case Quality.MILITARIZED:
					Modifiers.Law += 4;
					Modifiers.Society -= 4;
				break;
				case Quality.MOBILEFRONTLINES:
					Modifiers.Corruption -= 1;
					Modifiers.Economy -= 1;
					Modifiers.Society -= 1;
					Marketplace.BaseValue *= 1.25;
					Marketplace.PurchaseLimit *= 1.25;
				break;
				case Quality.MOBILESANCTUARY:
					Modifiers.Economy += 1;
					Modifiers.Society -= 1;
				break;
				case Quality.MORALLYPERMISSIVE:
					Modifiers.Corruption += 1;
					Modifiers.Economy += 1;
					Marketplace.Spellcasting -= 1;
				break;
				case Quality.MYTHICSANCTUM:
					Modifiers.Corruption -= 2;
				break;
				case Quality.NOQUESTIONSASKED:
					Modifiers.Society += 1;
					Modifiers.Lore -= 1;
				break;
				case Quality.NOTORIOUS:
					Modifiers.Crime += 1;
					Info.Danger += 10;
					Modifiers.Law -= 1;
					Marketplace.BaseValue *= 1.3;
					Marketplace.PurchaseLimit *= 1.5;
				break;
				case Quality.PEACEBONDING:
					Modifiers.Law += 1;
					Modifiers.Crime -= 1;
				break;
				case Quality.PHANTASMAL:
					Modifiers.Economy -= 2;
					Modifiers.Society -= 2;
					Marketplace.Spellcasting += 2;
				break;
				case Quality.PIOUS:
					Marketplace.Spellcasting += 1;
				break;
				case Quality.PLANARCROSSROADS:
					Modifiers.Crime += 3;
					Modifiers.Economy += 2;
					Info.Danger += 20;
					Marketplace.Spellcasting += 2;
					Marketplace.PurchaseLimit *= 1.25;
				break;
				case Quality.PLANNEDCOMMUNITY:
					Modifiers.Economy += 1;
					Modifiers.Crime -= 1;
					Modifiers.Society -= 1;
				break;
				case Quality.POCKETUNIVERSE:
					Marketplace.Spellcasting += 2;
					Modifiers.Economy -= 2;
				break;
				case Quality.POPULATIONSURGE:
					Modifiers.Crime += 1;
					Modifiers.Society += 2;
				break;
				case Quality.PROSPEROUS:
					Modifiers.Economy += 1;
					Marketplace.BaseValue *= 1.3;
					Marketplace.PurchaseLimit *= 1.5;
				break;
				case Quality.RACIALENCLAVE:
					Modifiers.Society -= 1;
				break;
				case Quality.RESETTLEDRUINS:
					Modifiers.Economy += 1;
					Modifiers.Lore += 1;
				break;
				case Quality.RELIGIOUSTOLERANCE:
					Modifiers.Lore += 1;
					Modifiers.Society += 1;
					Marketplace.Spellcasting += 2;
				break;
				case Quality.RESTRICTIVE:
					Modifiers.Corruption -= 1;
					Modifiers.Lore -= 1;
				break;
				case Quality.ROMANTIC:
					Modifiers.Society += 1;
				break;
				case Quality.ROYALACCOMMODATIONS:
					Modifiers.Economy += 1;
					Modifiers.Law += 2;
					Modifiers.Society -= 1;
				break;
				case Quality.RULEOFMIGHT:
					Modifiers.Law += 2;
					Modifiers.Society -= 2;
				break;
				case Quality.RUMORMONGERINGCITIZENS:
					Modifiers.Lore += 1;
					Modifiers.Society -= 1;
				break;
				case Quality.RURAL:
					Modifiers.Economy -= 1;
					Modifiers.Crime -= 1;
					Info.Danger -= 5;
				break;
				case Quality.SACREDANIMALS:
					Modifiers.Lore += 1;
					Modifiers.Corruption -= 1;
					Modifiers.Economy -= 1;
				break;
				case Quality.SEXIST:
					Modifiers.Society -= 2;
				break;
				case Quality.SLUMBERINGMONSTER:
					Modifiers.Lore += 2;
					Modifiers.Society += 1;
					Marketplace.Spellcasting += 2;
				break;
				case Quality.SMALLFOLKSETTLEMENT:
					Modifiers.Law += 1;
					Modifiers.Lore += 1;
				break;
				case Quality.STRATEGICLOCATION:
					Modifiers.Economy += 1;
					Marketplace.BaseValue *= 1.1;
				break;
				case Quality.SUBTERRANEAN:
					Modifiers.Law += 1;
					Modifiers.Lore -= 1;
					Info.Danger -= 5;
				break;
				case Quality.SUPERSTITIOUS:
					Modifiers.Law += 2;
					Modifiers.Society += 2;
					Modifiers.Crime -= 4;
					Marketplace.Spellcasting -= 2;
				break;
				case Quality.SUPPORTIVE:
					Modifiers.Society += 2;
				break;
				case Quality.TIMIDCITIZENS:
					Modifiers.Crime += 2;
					Modifiers.Lore -= 2;
				break;
				case Quality.THERAPEUTIC:
					Modifiers.Economy += 1;
					Modifiers.Lore += 1;
				break;
				case Quality.TRADINGPOST:
					Marketplace.PurchaseLimit *= 2;
				break;
				case Quality.TOURISTATTRACTION:
					Modifiers.Economy += 1;
					Marketplace.BaseValue *= 1.2;
				break;
				case Quality.UNAGING:
					Modifiers.Lore += 4;
					Modifiers.Society -= 3;
					Marketplace.Spellcasting += 1;
				break;
				case Quality.UNDERCITY:
					Modifiers.Lore += 1;
					Info.Danger += 20;
				break;
				case Quality.UNHOLYSITE:
					Modifiers.Corruption += 2;
					Marketplace.Spellcasting += 2;
				break;
				case Quality.WELLEDUCATED:
					Modifiers.Lore += 1;
					Modifiers.Society += 2;
				break;
				case Quality.WEALTHDISPARITY:
					//TODO Add poor/rich districts
				break;
			}
		}
	}

	private void CalculateDisadvantageModifiers() {
		foreach (Disadvantage d in Modifiers.Disadvantages){
			switch (d) {
				case Disadvantage.ANARCHY:
					Modifiers.Crime += 4;
					Modifiers.Economy -= 4;
					Modifiers.Society -= 4;
					Modifiers.Law -= 6;
				break;
				case Disadvantage.BUREAUCRATICNIGHTMARE:
					Modifiers.Economy -= 2;
					Modifiers.Crime += 2;
					Modifiers.Corruption += 2;
				break;
				case Disadvantage.FASCISTIC:
					Modifiers.Law += 4;
					Modifiers.Society -= 4;
				break;
				case Disadvantage.HEAVILYTAXED:
					Modifiers.Society -= 2;
					Marketplace.BaseValue *= 0.9;
					Marketplace.PurchaseLimit /= 2;
					Marketplace.Spellcasting -= 2;
				break;
				case Disadvantage.HUNTED:
					Modifiers.Economy -= 4;
					Modifiers.Law -= 4;
					Modifiers.Society -= 4;
					Info.Danger += 20;
					Marketplace.BaseValue *= 0.8;
				break;
				case Disadvantage.IGNORANT:
					Modifiers.Economy -= 3;
					Modifiers.Lore -= 6;
					Modifiers.Society -= 3;
				break;
				case Disadvantage.IMPOVERISHED:
					Modifiers.Corruption += 1;
					Modifiers.Crime += 1;
					Marketplace.BaseValue /= 2;
					Marketplace.PurchaseLimit /= 2;
				break;
				case Disadvantage.MAGICALLYDEADENED:
					Modifiers.Lore -= 1;
					Modifiers.Economy -= 1;
					Marketplace.Spellcasting -= 4;
				break;
				case Disadvantage.MAGICALDEADZONE:
					Marketplace.Spellcasting = 0;
				break;
				case Disadvantage.MARTIALLAW:
					Modifiers.Law += 2;
					Modifiers.Corruption -= 4;
					Modifiers.Crime -= 2;
					Modifiers.Economy -= 4;
					Info.Danger += 10;
				break;
				case Disadvantage.OPPRESSED:
					Modifiers.Lore -= 6;
					Modifiers.Society -= 6;
				break;
				case Disadvantage.PLAGUED:
					Modifiers.Corruption -= 2;
					Modifiers.Crime -= 2;
					Modifiers.Economy -= 2;
					Modifiers.Law -= 2;
					Modifiers.Lore -= 2;
					Modifiers.Society -= 2;
					Marketplace.BaseValue *= 0.8;
				break;
				case Disadvantage.RAMPANTINFLATION:
					Modifiers.Economy -= 4;
					Modifiers.Corruption += 2;
					Modifiers.Crime += 4;
				break;
				case Disadvantage.POLLUTED:
					Modifiers.Corruption += 2;
					Modifiers.Economy += 4;
				break;
				case Disadvantage.WILDMAGICZONE:
					Marketplace.Spellcasting -= 2;
				break;
			}
		}
	}
	
	#endregion
}