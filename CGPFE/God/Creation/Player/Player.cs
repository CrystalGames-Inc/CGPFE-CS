using CGPFE.Data.Models.Item.Equipment.Defense;
using CGPFE.Data.Models.Item.Equipment.Offense;
using CGPFE.Data.Storage.Items.Equipment.Defense;
using CGPFE.Data.Storage.Items.Equipment.Offense;
using CGPFE.God.Creation.General;
using CGPFE.God.Creation.General.Feat;
using CGPFE.God.Creation.General.Skills;
using CGPFE.God.Creation.Player.Properties;
using CGPFE.God.Creation.Player.Properties.Inventory;
using CGPFE.World;
using CGPFE.World.Settlement;
using Attribute = CGPFE.Data.Constants.Attribute;

namespace CGPFE.God.Creation.Player;

public class Player {
	public PlayerInfo PlayerInfo { get; set; } = new();
	public Attributes Attributes { get; set; } = new();
	public Attributes AttributeModifiers { get; set; } = new() {MoveSpeed = 0};
	public CombatInfo CombatInfo { get; set; } = new();
	public List<string> Skills { get; set; } = [];
	public List<string> Feats { get; set; } = [];
	public Inventory Inventory { get; set; } = new();
	public Wallet Wallet = new();
	
	public Location CurrentLocation { get; set; }

	#region Getters
	
	public int GetValueForKey(string key) {
		return key.ToUpper() switch {
			"STR" => Attributes.Strength,
			"DEX" => Attributes.Dexterity,
			"CON" => Attributes.Constitution,
			"INT" => Attributes.Intelligence,
			"WIS" => Attributes.Wisdom,
			"CHA" => Attributes.Charisma,
			"BAB" => CombatInfo.BaseAttackBonus,
			"LVL" => PlayerInfo.Level,
			"CLS" => (int)PlayerInfo.Class,
			"RCE" => (int)PlayerInfo.Race,
			"SZE" => (int)PlayerInfo.Size,
			_ => throw new InvalidOperationException($"Unsupported key: {key}"),
		};
	}
	
	public int GetAbilityScore(Attribute ability) {
		return ability switch {
			Attribute.Strength => Attributes.Strength,
			Attribute.Dexterity => Attributes.Dexterity,
			Attribute.Constitution => Attributes.Constitution,
			Attribute.Intelligence => Attributes.Intelligence,
			Attribute.Wisdom => Attributes.Wisdom,
			Attribute.Charisma => Attributes.Charisma,
			_ => 0
		};
	}
	
	public Feat? GetMatchingFeat(string featName) {
		return General.Feat.Feats.Feats.feats.FirstOrDefault(feat => feat.Name.ToUpper().Equals(featName.ToUpper()));
	}
	
	public Weapon? GetMatchingWeapon(string weaponName) {
		return Weapons.weapons.FirstOrDefault(weapon => weapon.Name.ToUpper().Equals(weaponName.ToUpper()));
	}
	
	public Armor? GetMatchingArmor(string armorName) {
		return Armors.armors.FirstOrDefault(armor => armor.Name.ToUpper().Equals(armorName.ToUpper()));
	}
	
	public Shield? GetMatchingShield(string shieldName) {
		return Shields.shields.FirstOrDefault(shield => shield.Name.ToUpper().Equals(shieldName.ToUpper()));
	}

	public Skill? GetMatchingSkill(string skillName) {
		return General.Skills.Skills.skills.FirstOrDefault(skill => skill.Name.ToUpper().Equals(skillName.ToUpper()));
	}
	
	#endregion
	
	public bool HasFeat(string featName) {
		return Feats.Any(playerFeat => playerFeat.ToUpper().Equals(featName.ToUpper()));
	}
	
	#region Displays
	
	public void DisplayBasicInfo() {
		Console.WriteLine("Player Info:");
		Console.WriteLine($"  Name: {PlayerInfo.Name}");
		Console.WriteLine($"  Gender: {PlayerInfo.Gender}");
		Console.WriteLine($"  Alignment: {PlayerInfo.Alignment}");
		Console.WriteLine($"  Age: {PlayerInfo.Age}");
		Console.WriteLine($"  Race: {PlayerInfo.Race}");
		Console.WriteLine($"  Size: {PlayerInfo.Size}");
		Console.WriteLine($"  Size Modifier: {PlayerInfo.SizeMod}");
		Console.WriteLine($"  Class: {PlayerInfo.Class}");
		Console.WriteLine($"  Level: {PlayerInfo.Level}");
		Console.WriteLine($"  Current XP: {PlayerInfo.Xp}");
		Console.WriteLine($"  Maximum Health: {PlayerInfo.MaxHealth}");
		Console.WriteLine($"  Current Health: {PlayerInfo.Health}");
	}
	
	public void DisplayAttributes() {
		Console.WriteLine("Attributes: ");
		Console.WriteLine($"  Strength: {Attributes.Strength}");
		Console.WriteLine($"  Dexterity: {Attributes.Dexterity}");
		Console.WriteLine($"  Constitution: {Attributes.Constitution}");
		Console.WriteLine($"  Intelligence: {Attributes.Intelligence}");
		Console.WriteLine($"  Wisdom: {Attributes.Wisdom}");
		Console.WriteLine($"  Charisma: {Attributes.Charisma}");
		Console.WriteLine($"  Move Speed: {Attributes.MoveSpeed}");
	}
	
	public void DisplayAttributeMods() {
		Console.WriteLine("Attribute Modifiers: ");
		Console.WriteLine($"  Strength: {AttributeModifiers.Strength}");
		Console.WriteLine($"  Dexterity: {AttributeModifiers.Dexterity}");
		Console.WriteLine($"  Constitution: {AttributeModifiers.Constitution}");
		Console.WriteLine($"  Intelligence: {AttributeModifiers.Intelligence}");
		Console.WriteLine($"  Wisdom: {AttributeModifiers.Wisdom}");
		Console.WriteLine($"  Charisma: {AttributeModifiers.Charisma}");
		Console.WriteLine($"  Move Speed: {AttributeModifiers.MoveSpeed}");
	}
	
	public void DisplayCombatInfo() {
		Console.WriteLine("Combat Info: ");
		Console.WriteLine($"  Init Modifier: {CombatInfo.InitMod}");
		Console.WriteLine($"  Base Attack  {CombatInfo.BaseAttackBonus}");
		Console.WriteLine($"  Fortitude: {CombatInfo.Fortitude}");
		Console.WriteLine($"  Reflex: {CombatInfo.Reflex}");
		Console.WriteLine($"  Will: {CombatInfo.Will}");
		Console.WriteLine($"  CMB: {CombatInfo.CombatManeuverBonus}");
		Console.WriteLine($"  CMD: {CombatInfo.CombatManeuverDefense}");
		Console.WriteLine($"  Armor Class:  {CombatInfo.ArmorClass}");
	}

	public void DisplayWeapons() {
		if (Inventory.Weapons == null) {
			Console.WriteLine("No weapons on character");
		}
		else {
			Console.WriteLine($"Weapons detected: {Inventory.Weapons.Count}");
			for (var i = 0; i < Inventory.Weapons.Count; ++i) {
				Console.WriteLine($"{i + 1}: {Inventory.Weapons[i].Name}");
			}
		}
	}

	public void DisplayArmors() {
		if (Inventory.Armors == null) {
			Console.WriteLine("No armor on character");
		}
		else {
			Console.WriteLine($"Armors detected: {Inventory.Armors.Count}");
			for (var i = 0; i < Inventory.Armors.Count; ++i) {
				Console.WriteLine($"{i + 1}: {Inventory.Armors[i].Name}");
			}
		}
	}

	public void DisplayShields() {
		if (Inventory.Shields == null) {
			Console.WriteLine("No shield on character");
		}
		else {
			Console.WriteLine($"Shields detected: {Inventory.Shields.Count}");
			for (var i = 0; i < Inventory.Shields.Count; ++i) {
				Console.WriteLine($"{i + 1}: {Inventory.Shields[i].Name}");
			}
		}
	}

	public void DisplayWallet() {
		Console.WriteLine("Wallet: ");
		Console.WriteLine($"  Copper: {Wallet.CopperPieces}");
		Console.WriteLine($"  Silver: {Wallet.SilverPieces}");
		Console.WriteLine($"  Gold: {Wallet.GoldPieces}");
		Console.WriteLine($"  Platinum: {Wallet.PlatinumPieces}");
	}
	
	public void DisplayCurrentLocation() {
		if(CurrentLocation == null)
			Console.WriteLine("You are now in the abyss, the void. You can see nothing, hear nothing.");
		else if (CurrentLocation.GetType() == typeof(Region))
			Console.WriteLine($"You are currently in {CurrentLocation.Name} region, roaming around");
		else if (CurrentLocation.GetType() == typeof(Settlement))
			Console.WriteLine($"You are currently in the settlement of {CurrentLocation.Name}, roaming around");
		else if(CurrentLocation.GetType() == typeof(Location))
			Console.WriteLine($"You are currently in {CurrentLocation.Name}");
	}
	
	#endregion
}