using System.Net.Mime;
using System.Text.Json;
using CGPFE.Data.Constants;
using CGPFE.Data.Game;
using CGPFE.God.Creation.General;
using CGPFE.God.Creation.Player;

namespace CGPFE.Management;

public class PlayerDataManager {
	private readonly Player _player = new Player();

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
		
		RegisterPlayerRace();
		RegisterPlayerClass();
	}

	private void RegisterPlayerName() {
		Console.WriteLine("Please choose your character's name: ");
		var name = Console.ReadLine();
		if (string.IsNullOrEmpty(name)) {
			Console.WriteLine("Cannot enter an empty name");
			RegisterPlayerName();
		}
		_player.PlayerInfo.Name = name;
	}

	private void RegisterPlayerGender() {
		while (true) {
			Console.WriteLine("Please choose your character's gender:\nMale\nFemale");
			var gender = Console.ReadLine();
			switch (gender.ToUpper()) {
				case "MALE":
					_player.PlayerInfo.Gender = Gender.Male;
				break;
				case "FEMALE":
					_player.PlayerInfo.Gender = Gender.Female;
				break;
				default:
					Console.WriteLine("Invalid gender selected");
					continue;
			}

			break;
		}
	}

	private void RegisterPlayerRace() {
		while (true) {
			Console.WriteLine("Please choose your character's race:\nDwarf\nElf\nGnome\nHalfElf\nHalfOrc\nHalfling\nHuman");
			var race = Console.ReadLine();
			switch (race.ToUpper()) {
				case "DWARF":
					_player.PlayerInfo.Race = Race.Dwarf;
				break;
				case "ELF":
					_player.PlayerInfo.Race = Race.Elf;
				break;
				case "GNOME":
					_player.PlayerInfo.Race = Race.Gnome;
				break;
				case "HALFELF":
					_player.PlayerInfo.Race = Race.HalfElf;
				break;
				case "HALFORC":
					_player.PlayerInfo.Race = Race.HalfOrc;
				break;
				case "HALFLING":
					_player.PlayerInfo.Race = Race.Halfling;
				break;
				case "HUMAN":
					_player.PlayerInfo.Race = Race.Human;
				break;
				default:
					Console.WriteLine("Invalid race selected");
					continue;
			}

			break;
		}
	}

	private void RegisterPlayerClass() {
		Console.WriteLine(
			"Please select a class:\nAlchemist\nBarbarian\nBard\nCavalier\nCleric\nDruid\nFighter\nInquisitor\nMonk\nOracle\nPaladin\nRanger\nRogue\nSorcerer\nSummoner\nWitch\nWizard");
		var pClass = Console.ReadLine();
		_player.PlayerInfo.Class = pClass?.ToUpper() switch {
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
			_ => throw new NotImplementedException()
		};
		LoadPlayerCombatDataTable();
	}

	private void LoadPlayerCombatDataTable() {
		var fileName = _player.PlayerInfo.Class switch {
			Class.Alchemist => "AlchemistCT.json",
			Class.Barbarian => "BarbarianCT.json",
			Class.Bard => "BardCT.json",
			Class.Cavalier => "CavalierCT.json",
			Class.Cleric => "ClericCT.json",
			Class.Druid => "DruidCT.json",
			Class.Fighter => "FighterCT.json",
			Class.Inquisitor => "InquisitorCT.json",
			Class.Monk => "MonkCT.json",
			Class.Oracle => "OracleCT.json",
			Class.Paladin => "PaladinCT.json",
			Class.Ranger => "RangerCT.json",
			Class.Rogue => "RogueCT.json",
			Class.Sorcerer => "SorcererCT.json",
			Class.Summoner => "SummonerCT.json",
			Class.Witch => "WitchCT.json",
			Class.Wizard => "WizardCT.json",
			Class.None => throw new NotImplementedException(),
			_ => throw new NotImplementedException()
		};
		var path = Path.Combine(System.Reflection.Assembly.GetExecutingAssembly().Location, "Resources", "CombatTables", fileName);
		Console.WriteLine("Final Path: " + path);
		
		//TODO fix the god damn combat table loading.
		// if (combatTable == null) {
		// 	Console.WriteLine("Error loading combat table");
		// 	return;
		// }	
		// Player.CombatInfo.BaseAttackBonus = combatTable[0].BAB;
		// Player.CombatInfo.Fortitude = combatTable[0].Fort;
		// Player.CombatInfo.Reflex = combatTable[0].Ref;
		// Player.CombatInfo.Will = combatTable[0].Will;
	}

	private Alignment RegisterAlignment(Alignment[] alignments) {
		Console.WriteLine("Please choose your alignment:");
		foreach (var a in alignments) {
			Console.WriteLine(a);
		}
		return Alignment.Neutral;
	}

	#endregion
	
	#region Ability Points

	private void RegisterAbilityPoints() {
		
	}
	
	#endregion
	
	#region Stat Displays

	public void DisplayAttributes() {
		Console.WriteLine("Attributes: ");
		Console.WriteLine($"  Strength: {_player.Attributes.Strength}");
		Console.WriteLine($"  Dexterity: {_player.Attributes.Dexterity}");
		Console.WriteLine($"  Constitution: {_player.Attributes.Constitution}");
		Console.WriteLine($"  Intelligence: {_player.Attributes.Intelligence}");
		Console.WriteLine($"  Wisdom: {_player.Attributes.Wisdom}");
		Console.WriteLine($"  Charisma: {_player.Attributes.Charisma}");
		Console.WriteLine($"  Move Speed: {_player.Attributes.MoveSpeed}");
	}

	public void DisplayAttributeMods() {
		Console.WriteLine("Attribute Modifiers: ");
		Console.WriteLine($"  Strength: {_player.AttributeModifiers.Strength}");
		Console.WriteLine($"  Dexterity: {_player.AttributeModifiers.Dexterity}");
		Console.WriteLine($"  Constitution: {_player.AttributeModifiers.Constitution}");
		Console.WriteLine($"  Intelligence: {_player.AttributeModifiers.Intelligence}");
		Console.WriteLine($"  Wisdom: {_player.AttributeModifiers.Wisdom}");
		Console.WriteLine($"  Charisma: {_player.AttributeModifiers.Charisma}");
		Console.WriteLine($"  Move Speed: {_player.AttributeModifiers.MoveSpeed}");
	}

	public void DisplayCombatInfo() {
		Console.WriteLine("Comat Info: ");
		Console.WriteLine($"  Base Attack Bonus: {_player.CombatInfo.BaseAttackBonus}");
		Console.WriteLine($"  Fortitude: {_player.CombatInfo.Fortitude}");
		Console.WriteLine($"  Reflex: {_player.CombatInfo.Reflex}");
		Console.WriteLine($"  Will: {_player.CombatInfo.Will}");
		Console.WriteLine($"  Armor Class:  {_player.CombatInfo.ArmorClass}");
	}
	
	#endregion
}