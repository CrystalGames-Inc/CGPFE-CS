using System.Text.Json;
using CGPFE.Data.Constants;
using CGPFE.God.Creation.General;
using CGPFE.God.Creation.Player.Properties;

namespace CGPFE.God.Creation.Player;

public class Player {
	public PlayerInfo PlayerInfo = new();
	public Attributes Attributes = new();
	public Attributes AttributeModifiers = new();
	public CombatInfo CombatInfo = new();
	public Wallet Wallet = new();

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
}