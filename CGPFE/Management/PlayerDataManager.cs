using CGPFE.Data.Constants;
using CGPFE.Data.Game.StoryModifiers;
using CGPFE.God.Creation.Player;
using CGPFE.Mechanics;
using Attribute = CGPFE.Data.Constants.Attribute;

namespace CGPFE.Management;

public class PlayerDataManager {
	public Player Player = new Player();

	private static PlayerDataManager _instance = null;
	private static readonly object Padlock = new object();

	public static PlayerDataManager Instance {
		get {
			lock (Padlock) {
				_instance ??= new PlayerDataManager();
			}
			return _instance;
		}
	}
	
	#region Player Registration

	public void RegisterPlayer() {
		RegisterPlayerName();
		RegisterPlayerGender();
		
		RegisterAbilityScores();
		
		RegisterPlayerRace();
		RegisterPlayerClass();
		
		//TODO add the rest of the registration & calculation methods here :)
		
		CalculatePlayerCombatInfo();
		CalculateAbilityModifiers();
		
		FileManager.WritePlayerData();
	}

	private void RegisterPlayerName() {
		Console.WriteLine("Please choose your character's name: ");
		var name = Console.ReadLine();
		if (string.IsNullOrEmpty(name)) {
			Console.WriteLine("Cannot enter an empty name");
			RegisterPlayerName();
		}
		Player.PlayerInfo.Name = name;
	}

	private void RegisterPlayerGender() {
		while (true) {
			Console.WriteLine("Please choose your character's gender:\nMale\nFemale");
			var gender = Console.ReadLine();
			switch (gender.ToUpper()) {
				case "MALE":
					Player.PlayerInfo.Gender = Gender.Male;
				break;
				case "FEMALE":
					Player.PlayerInfo.Gender = Gender.Female;
				break;
				default:
					Console.WriteLine("Invalid gender selected");
					continue;
			}

			break;
		}
	}

	private void RegisterAbilityScores() {
		
		List<int> abilityScores = [];
		
		switch (GameDataManager.Instance.GameData.AbilityScoreType) {
			case AbilityScoreType.Standard:
				for (var i = 0; i < 6; i++) {
					int[] rolls = [
						Dice.Roll(6),
						Dice.Roll(6),
						Dice.Roll(6),
						Dice.Roll(6)
					];
					abilityScores.Add(rolls.OrderByDescending(x => x).Take(3).Sum());
				}
			break;
			case AbilityScoreType.Classic:
				for (var i = 0; i < 6; i++) {
					int[] rolls = [
						Dice.Roll(6),
						Dice.Roll(6),
						Dice.Roll(6)
					];
					abilityScores.Add(rolls.Sum());
				}
			break;
			case AbilityScoreType.Heroic:
				for (var i = 0; i < 6; i++) {
					int[] rolls = [
						Dice.Roll(6),
						Dice.Roll(6),
						Dice.Roll(6)
					];
					abilityScores.Add(rolls.Sum() + 6);
				}
			break;
		}
		
		Attribute[] attributeOrder = [
		Attribute.Strength,
		Attribute.Dexterity,
		Attribute.Constitution,
		Attribute.Intelligence,
		Attribute.Wisdom,
		Attribute.Charisma
		];

		foreach (var attribute in attributeOrder)
		{
			Console.WriteLine("Available scores:");
			for (int i = 0; i < abilityScores.Count; i++)
			{
				Console.WriteLine($"{i + 1}. {abilityScores[i]}");
			}

			int index;
			while (true)
			{
				Console.Write($"\nSelect the index (1-{abilityScores.Count}) of the score to assign to {attribute}: ");
				if (int.TryParse(Console.ReadLine(), out index) &&
				    index >= 1 &&
				    index <= abilityScores.Count)
				{
					break;
				}
				Console.WriteLine("Invalid index. Please try again.");
			}

			int chosenScore = abilityScores[index - 1];
			abilityScores.RemoveAt(index - 1);

			// Assign the chosen score to the correct property
			switch (attribute)
			{
				case Attribute.Strength:
					Player.Attributes.Strength = chosenScore;
					break;
				case Attribute.Dexterity:
					Player.Attributes.Dexterity = chosenScore;
					break;
				case Attribute.Constitution:
					Player.Attributes.Constitution = chosenScore;
					break;
				case Attribute.Intelligence:
					Player.Attributes.Intelligence = chosenScore;
					break;
				case Attribute.Wisdom:
					Player.Attributes.Wisdom = chosenScore;
					break;
				case Attribute.Charisma:
					Player.Attributes.Charisma = chosenScore;
					break;
			}

			Console.WriteLine($"Assigned {chosenScore} to {attribute}");
		}
		
		CalculateAbilityModifiers();
	}

	private void RegisterPlayerRace() {
		Console.WriteLine("Please choose your character's race:\nDwarf\nElf\nGnome\nHalfElf\nHalfOrc\nHalfling\nHuman");
		var race = Console.ReadLine();
		Player.PlayerInfo.Race = race.ToUpper() switch {
			"DWARF" => Race.Dwarf,
			"ELF" => Race.Elf,
			"GNOME" => Race.Gnome,
			"HALFELF" => Race.HalfElf,
			"HALFORC" => Race.HalfOrc,
			"HALFLING" => Race.Halfling,
			"HUMAN" => Race.Human,
			_ => Race.None
		};
		
		CalculateRacialBonus();
	}

	private void RegisterPlayerClass() {
		Console.WriteLine(
			"Please select a class:\nAlchemist\nBarbarian\nBard\nCavalier\nCleric\nDruid\nFighter\nInquisitor\nMonk\nOracle\nPaladin\nRanger\nRogue\nSorcerer\nSummoner\nWitch\nWizard");
		var pClass = Console.ReadLine();
		Player.PlayerInfo.Class = pClass?.ToUpper() switch {
			"ALCHEMIST" => Class.Alchemist,
			"BARBARIAN" => Class.Barbarian,
			"BARD" => Class.Bard,
			"CAVALIER" => Class.Cavalier,
			"CLERIC" => Class.Cleric,
			"DRUID" => Class.Druid,
			"FIGHTER" => Class.Fighter,
			"INQUISITOR" => Class.Inquisitor,
			"MONK" => Class.Monk,
			"ORACLE" => Class.Oracle,
			"PALADIN" => Class.Paladin,
			"RANGER" => Class.Ranger,
			"ROGUE" => Class.Rogue,
			"SORCERER" => Class.Sorcerer,
			"SUMMONER" => Class.Summoner,
			"WITCH" => Class.Witch,
			"WIZARD" => Class.Wizard,
			_ => throw new ArgumentException()
		};
		FileManager.CreateCombatTable();
		
		CalculateMaxHealth();
		RegisterAlignment();
	}

	private void RegisterAlignment() {
		var alignmentIn = "";
        switch (Player.PlayerInfo.Class){
            case Class.Barbarian: {
                Console.WriteLine("Please Select An Alignment:\nNeutralGood\nChaoticGood\nNeutral\nChaoticNeutral\nNeutralEvil\nChaoticEvil");
                alignmentIn = Console.ReadLine();
                Player.PlayerInfo.Alignment = alignmentIn.ToUpper() switch {
	                "NEUTRALGOOD" => Alignment.NeutralGood,
	                "CHAOTICGOOD" => Alignment.ChaoticGood,
	                "NEUTRAL" => Alignment.Neutral,
	                "CHAOTICNEUTRAL" => Alignment.ChaoticNeutral,
	                "NEUTRALEVIL" => Alignment.NeutralEvil,
	                "CHAOTICEVIL" => Alignment.ChaoticEvil,
	                _ => Player.PlayerInfo.Alignment
                };
                break;
            }
	        case Class.Alchemist: case Class.Bard: case Class.Cavalier: case Class.Cleric: case Class.Fighter: case Class.Oracle: case Class.Ranger: case Class.Rogue: case Class.Sorcerer: case Class.Summoner: case Class.Witch: case Class.Wizard:
                Console.WriteLine("Please Select An Alignment:\nLawfulGood\nNeutralGood\nChaoticGood\nLawfulNeutral\nNeutral\nChaoticNeutral\nLawfulEvil\nNeutralEvil\nChaoticEvil");
                alignmentIn = Console.ReadLine().ToUpper();
                Player.PlayerInfo.Alignment = alignmentIn switch {
	                "LAWFULGOOD" => Player.PlayerInfo.Alignment = Alignment.LawfulGood,
	                "NEUTRALGOOD" => Player.PlayerInfo.Alignment = Alignment.NeutralGood,
	                "CHAOTICGOOD" => Player.PlayerInfo.Alignment = Alignment.ChaoticGood,
	                "LAWFULNEUTRAL" => Player.PlayerInfo.Alignment = Alignment.LawfulNeutral,
	                "NEUTRAL" => Player.PlayerInfo.Alignment = Alignment.Neutral,
	                "CHAOTICNEUTRAL" => Player.PlayerInfo.Alignment = Alignment.ChaoticNeutral,
	                "LAWFULEVIL" => Player.PlayerInfo.Alignment = Alignment.LawfulEvil,
	                "NEUTRALEVIL" => Player.PlayerInfo.Alignment = Alignment.NeutralEvil,
	                "CHAOTICEVIL" => Player.PlayerInfo.Alignment = Alignment.ChaoticEvil,
	                _ => Player.PlayerInfo.Alignment
                };
		        break;
	        
            case Class.Druid:
                Console.WriteLine("Please Select An Alignment:\nNeutralGood\nLawfulNeutral\nNeutral\nChaoticNeutral\nNeutralEvil");
                alignmentIn = Console.ReadLine().ToUpper();
                Player.PlayerInfo.Alignment = alignmentIn switch{
                    "NEUTRALGOOD" => Player.PlayerInfo.Alignment = Alignment.NeutralGood,
                    "LAWFULNEUTRAL" => Player.PlayerInfo.Alignment = Alignment.LawfulNeutral,
                    "NEUTRAL" => Player.PlayerInfo.Alignment = Alignment.Neutral,
                    "CHAOTICNEUTRAL" => Player.PlayerInfo.Alignment = Alignment.ChaoticNeutral,
                    "NEUTRALEVIL" => Player.PlayerInfo.Alignment = Alignment.NeutralEvil,
                    _ => Player.PlayerInfo.Alignment
                } ;
	            break;
            
            case Class.Monk:
                Console.WriteLine("Please Select An Alignment:\nLawfulGood\nLawfulNeutral\nLawfulEvil");
                alignmentIn = Console.ReadLine().ToUpper();
                Player.PlayerInfo.Alignment = alignmentIn switch {
	                "LAWFULGOOD" => Player.PlayerInfo.Alignment = Alignment.LawfulGood,
	                "LAWFULNEUTRAL" => Player.PlayerInfo.Alignment = Alignment.LawfulNeutral,
	                "LAWFULEVIL" => Player.PlayerInfo.Alignment = Alignment.LawfulEvil,
                };
				break;
            case Class.Paladin: Player.PlayerInfo.Alignment = Alignment.LawfulGood; break;
        }
	}

	#endregion
	
	#region Data Calculations

	private void CalculateRacialBonus() {
		while (true) {
			switch (Player.PlayerInfo.Race) {
				case Race.Dwarf:
					Player.Attributes.Constitution += 2;
					Player.Attributes.Wisdom += 2;
					Player.Attributes.Charisma -= 2;
					break;
				case Race.Elf:
					Player.Attributes.Dexterity += 2;
					Player.Attributes.Intelligence += 2;
					Player.Attributes.Constitution -= 2;
					break;
				case Race.Gnome:
					Player.Attributes.Constitution += 2;
					Player.Attributes.Charisma += 2;
					Player.Attributes.Strength -= 2;
					break;
				case Race.HalfElf:
				case Race.HalfOrc:
				case Race.Human:
					Console.WriteLine("Choose an attribute to enhance by 2:\n1. Strength\n2. Dexterity\n3. Constitution\n4. Intelligence\n5. Wisdom\n6. Charisma");
					var ans = Convert.ToInt32(Console.ReadLine());
					switch (ans) {
						case 1:
							Player.Attributes.Strength += 2;
							break;
						case 2:
							Player.Attributes.Dexterity += 2;
							break;
						case 3:
							Player.Attributes.Constitution += 2;
							break;
						case 4:
							Player.Attributes.Intelligence += 2;
							break;
						case 5:
							Player.Attributes.Wisdom += 2;
							break;
						case 6:
							Player.Attributes.Charisma += 2;
							break;
						default:
							continue;
					}

					break;
				case Race.Halfling:
					Player.Attributes.Dexterity += 2;
					Player.Attributes.Charisma += 2;
					Player.Attributes.Strength -= 2;
					break;
			}

			break;
		}
	}

	private void CalculateAbilityModifiers() {
		int[] abilities = [Player.Attributes.Strength, Player.Attributes.Dexterity, Player.Attributes.Constitution, Player.Attributes.Intelligence, Player.Attributes.Wisdom, Player.Attributes.Charisma];
		var abilityMods = new int[6];
		
		for (var i = 0; i < abilities.Length; i++) {
			double value = abilities[i];
			abilityMods[i] = (int)Math.Floor((value - 10) / 2);
		}
		
		Player.AttributeModifiers.Strength =     abilityMods[0];
		Player.AttributeModifiers.Dexterity =    abilityMods[1];
		Player.AttributeModifiers.Constitution = abilityMods[2];
		Player.AttributeModifiers.Intelligence = abilityMods[3];
		Player.AttributeModifiers.Wisdom =   	 abilityMods[4];
		Player.AttributeModifiers.Charisma = 	 abilityMods[5];
		
		CalculateInitMod();
	}
	
	private void CalculateInitMod() {
		var init = 0;

		init += Player.AttributeModifiers.Dexterity;

		Player.CombatInfo.InitMod = init;
	}
	
	private void CalculatePlayerCombatInfo() {
		CalculateArmorClass();
		CalculateCombatManeuverBonus();
		CalculateCombatManeuverDefense();
	}

	private void CalculateArmorClass() {
		var ac = 10;

		if (Player.CombatInfo.Armors != null) {
			foreach (var a in Player.CombatInfo.Armors) {
				if (a != null)
					ac += a.ArmorBonus;
			}
		}

		if (Player.CombatInfo.Shields != null) {
			foreach (var s in Player.CombatInfo.Shields) {
				if (s != null)
					ac += s.ShieldBonus;
			}
		}

		ac += Player.AttributeModifiers.Dexterity;
		ac += Player.PlayerInfo.SizeMod;

		Player.CombatInfo.ArmorClass = ac;
	}

	private void CalculateCombatManeuverBonus() {
		var cmb = 0;

		cmb += Player.CombatInfo.BaseAttackBonus;
		cmb += Player.AttributeModifiers.Strength;
		cmb += Player.PlayerInfo.SizeMod;

		Player.CombatInfo.CombatManeuverBonus = cmb;
	}

	private void CalculateCombatManeuverDefense() {
		var cmd = 10;
		
		cmd += Player.CombatInfo.BaseAttackBonus;
		cmd += Player.AttributeModifiers.Strength;
		cmd += Player.AttributeModifiers.Dexterity;
		cmd += Player.PlayerInfo.SizeMod;
		
		Player.CombatInfo.CombatManeuverDefense = cmd;
	}

	private void CalculateMaxHealth() {
		Player.PlayerInfo.MaxHealth = Player.PlayerInfo.Class switch {
			Class.Alchemist => 9 + Player.AttributeModifiers.Constitution,
			Class.Barbarian => 13 + Player.AttributeModifiers.Constitution,
			Class.Bard => 9 + Player.AttributeModifiers.Constitution,
			Class.Cavalier => 11 + Player.AttributeModifiers.Constitution,
			Class.Cleric => 9 + Player.AttributeModifiers.Constitution,
			Class.Druid => 9 + Player.AttributeModifiers.Constitution,
			Class.Fighter => 11 + Player.AttributeModifiers.Constitution,
			Class.Inquisitor => 9 + Player.AttributeModifiers.Constitution,
			Class.Monk => 9 + Player.AttributeModifiers.Constitution,
			Class.Oracle => 9 + Player.AttributeModifiers.Constitution,
			Class.Paladin => 11 + Player.AttributeModifiers.Constitution,
			Class.Ranger => 11 + Player.AttributeModifiers.Constitution,
			Class.Rogue => 9 + Player.AttributeModifiers.Constitution,
			Class.Sorcerer => 7 + Player.AttributeModifiers.Constitution,
			Class.Summoner => 9 + Player.AttributeModifiers.Constitution,
			Class.Witch => 7 + Player.AttributeModifiers.Constitution,
			Class.Wizard => 7 + Player.AttributeModifiers.Constitution
		};
	}

	#endregion
}