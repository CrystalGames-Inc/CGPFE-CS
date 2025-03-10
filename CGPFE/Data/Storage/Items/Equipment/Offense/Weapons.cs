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
	
	#region One-Handed Melee Weapons
	
	public static Weapon Club = new Weapon(
		"Club",7,1,0, 
		new Damage(4),new Damage(6),
		new Critical(2),
		10,3, 
		[Type.Bludgeoning], null);
	
	public static Weapon HeavyMace = new Weapon(
		"Heavy Mace",8,1,12,
		new Damage(6),new Damage(8),
		new Critical(2),
		0,3, 
		[Type.Bludgeoning], null);
	
	public static Weapon Morningstar = new Weapon(
		"Morningstar",9,1, 8, 
		new Damage(6), new Damage(8), 
		new Critical(2),
		0,6,
		[Type.Bludgeoning, Type.Piercing, Type.And], null);
	
	public static Weapon Shortspear = new Weapon(
			"Shortspear",10,1, 1, 
			new Damage(4), new Damage(6),
			new Critical(2),
			20, 3, 
			[Type.Piercing], null);
	
	#endregion
	
	#region Two-Handed Melee Weapons
	
	public static Weapon Longspear = new Weapon(
		"Longspear",11,1, 5, 
		new Damage(6), new Damage(8), 
		new Critical(3),
		0, 9, 
		[Type.Bludgeoning], [Special.Brace, Special.Reach]);
	
	public static Weapon Quarterstaff = new Weapon(
		"Quarterstaff",12,1,0, 
		new Damage(4),new Damage(6),
		new Critical(2),
		0, 4, 
		[Type.Bludgeoning], [Special.Double, Special.Monk]);
	
	public static Weapon Spear = new Weapon(
			"Spear", 13,1,2, 
			new Damage(6),new Damage(8),
			new Critical(3),
			20,6,
			[Type.Piercing], [Special.Brace]);
	
	#endregion
	
	#region Ranged Weapons
	
	public static RangedWeapon Blowgun = new RangedWeapon(
		"Blowgun",14,1, 2, 
		new Damage(1),new Damage(2),
		new Critical(2),
		20,1, 
		Munitions.BlowgunDarts, 
		[Type.Piercing], null);
	
	public static RangedWeapon HeavyCrossbow = new RangedWeapon(
		"Heavy Crossbow",15,1, 50,
		new Damage(8),new Damage(10),
		new Critical(2,19),
		120,8,
		Munitions.CrossbowBolts,
		[Type.Piercing], null);
	
	public static RangedWeapon LightCrossbow = new RangedWeapon(
		"Light Crossbow",16,1, 30,
		new Damage(6),new Damage(8),
		new Critical(2,19),
		80, 4,
		Munitions.CrossbowBolts,
		[Type.Piercing], null);
	
	public static RangedWeapon Dart = new RangedWeapon(
		"Dart",17,1, 0.5,
		new Damage(3), new Damage(4),
		new Critical(2),
		20, 0.5,
		null,
		[Type.Piercing], null);
	
	public static RangedWeapon Javelin = new RangedWeapon(
		"Javelin",18,1,1,
		new Damage(4),new Damage(6),
		new Critical(2),
		30,2,
		null,
		[Type.Piercing], null);
	
	public static RangedWeapon Sling = new RangedWeapon(
		"Sling",19,1,0,
		new Damage(3),new Damage(4),
		new Critical(2),
		50, 0.0,
		Munitions.SlingBullets,
		[Type.Bludgeoning], null);
	
	#endregion
	
	#endregion
}