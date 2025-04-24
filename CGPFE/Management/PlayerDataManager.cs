using System.Net.Mime;
using System.Text.Json;
using CGPFE.Data.Constants;
using CGPFE.Data.Game;
using CGPFE.God.Creation.General;
using CGPFE.God.Creation.Player;

namespace CGPFE.Management;

public class PlayerDataManager {
	public readonly Player Player = new Player();

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
		
		//TODO add the rest of the registration & calculation methods here :)
		
		CalculatePlayerCombatInfo();
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
	}

	private Alignment RegisterAlignment(Alignment[] alignments) {
		Console.WriteLine("Please choose your alignment:");
		foreach (var a in alignments) {
			Console.WriteLine(a);
		}
		return Alignment.Neutral;
	}

	#endregion
	
	#region Data Calculations

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
	
	#endregion
	
	#region Ability Points

	private void RegisterAbilityPoints() {
		
	}
	
	#endregion
	
	#region Stat Displays

	public void DisplayAttributes() {
		Console.WriteLine("Attributes: ");
		Console.WriteLine($"  Strength: {Player.Attributes.Strength}");
		Console.WriteLine($"  Dexterity: {Player.Attributes.Dexterity}");
		Console.WriteLine($"  Constitution: {Player.Attributes.Constitution}");
		Console.WriteLine($"  Intelligence: {Player.Attributes.Intelligence}");
		Console.WriteLine($"  Wisdom: {Player.Attributes.Wisdom}");
		Console.WriteLine($"  Charisma: {Player.Attributes.Charisma}");
		Console.WriteLine($"  Move Speed: {Player.Attributes.MoveSpeed}");
	}

	public void DisplayAttributeMods() {
		Console.WriteLine("Attribute Modifiers: ");
		Console.WriteLine($"  Strength: {Player.AttributeModifiers.Strength}");
		Console.WriteLine($"  Dexterity: {Player.AttributeModifiers.Dexterity}");
		Console.WriteLine($"  Constitution: {Player.AttributeModifiers.Constitution}");
		Console.WriteLine($"  Intelligence: {Player.AttributeModifiers.Intelligence}");
		Console.WriteLine($"  Wisdom: {Player.AttributeModifiers.Wisdom}");
		Console.WriteLine($"  Charisma: {Player.AttributeModifiers.Charisma}");
		Console.WriteLine($"  Move Speed: {Player.AttributeModifiers.MoveSpeed}");
	}

	public void DisplayCombatInfo() {
		Console.WriteLine("Combat Info: ");
		Console.WriteLine($"  Init Modifier: {Player.CombatInfo.InitMod}");
		Console.WriteLine($"  Base Attack Bonus: {Player.CombatInfo.BaseAttackBonus}");
		Console.WriteLine($"  Fortitude: {Player.CombatInfo.Fortitude}");
		Console.WriteLine($"  Reflex: {Player.CombatInfo.Reflex}");
		Console.WriteLine($"  Will: {Player.CombatInfo.Will}");
		Console.WriteLine($"  CMB: {Player.CombatInfo.CombatManeuverBonus}");
		Console.WriteLine($"  CMD: {Player.CombatInfo.CombatManeuverDefense}");
		Console.WriteLine($"  Armor Class:  {Player.CombatInfo.ArmorClass}");
	}
	
	#endregion
}