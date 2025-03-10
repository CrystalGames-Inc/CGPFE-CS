using CGPFE.Data.Models.Item.Offense;
using CGPFE.Data.Models.Item.Offense.Properties;
using Type = CGPFE.Data.Models.Item.Offense.Properties.Type;

namespace CGPFE.Data.Storage.Items.Equipment.Offense;

public class Weapons {
	#region SimpleWeapons

	#region Unarmed Attacks

	public static Weapon Gauntlet = new Weapon("Gauntlet", 0, 1, 2, 
		new Damage(2), new Damage(3), 
		new Critical(2),
		0, 1, 
		[Type.Bludgeoning], null);

	public static Weapon UnarmedStrike = new Weapon("Unarmed Strike", 1, 1, 0, 
		new Damage(2), new Damage(3), 
		new Critical(2),
		0, 0, 
		[Type.Bludgeoning], [Special.Nonlethal]);

	#endregion
	
	#region Light Melee Weapons

	public static Weapon Dagger = new Weapon(
		"Dagger", 2, 1, 2, 
		new Damage(3), new Damage(4), 
		new Critical(2, 19), 
		10, 1, 
		[Type.Piercing, Type.Slashing, Type.Or], null);

	public static Weapon PunchingDagger = new Weapon(
		"Punching Dagger", 3, 1, 2, 
		new Damage(3), new Damage(4), 
		new Critical(3), 
		0, 1, 
		[Type.Piercing], null);
	
	public static Weapon SpikedGauntlet = new Weapon(
		"Spiked Gauntlet",4,1,5, 
		new Damage(3), new Damage(4), 
		new Critical(2), 
		0,1,
		[Type.Piercing], null);
	
	public static Weapon LightMace = new Weapon(
		"Light Mace",5,1,5,
		new Damage(4), new Damage(5),
		new Critical(2),
		0,4,
		[Type.Bludgeoning], null);

	public static Weapon Sickle = new Weapon(
		"Sickle", 6, 1, 6,
		new Damage(4), new Damage(6),
		new Critical(2),
		0, 2,
		[Type.Slashing], [Special.Trip]);

	#endregion
	#endregion
}