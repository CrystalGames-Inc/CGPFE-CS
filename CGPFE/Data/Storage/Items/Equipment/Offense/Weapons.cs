using CGPFE.Data.Models.Item.Offense;
using CGPFE.Data.Models.Item.Offense.Properties;
using Type = CGPFE.Data.Models.Item.Offense.Properties.Type;

namespace CGPFE.Data.Storage.Items.Equipment.Offense;

public class Weapons {
	#region Simple Weapons

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
	
	#region Martial Weapons

	#region Light Melee Weapons

	public static Weapon ThrowingAxe = new Weapon(
		"Throwing axe",20,1,8, 
		new Damage(4),new Damage(6), 
		new Critical(2),
		10, 2,
		[Type.Slashing], null);
	
	public static Weapon LightHammer = new Weapon(
		"Light Hammer",21,1,1, 
		new Damage(3),new Damage(4), 
		new Critical(2),
		20, 2,
		[Type.Bludgeoning], null);
	
	public static Weapon Handaxe = new Weapon(
		"Handaxe",22,1,6,
		new Damage(4),new Damage(6),
		new Critical(3),
		0,3,
		[Type.Slashing], null);
	
	public static Weapon Kukri = new Weapon(
		"Kukri",23,1,8,
		new Damage(3),new Damage(4),
		new Critical(2,18),
		0,2,
		[Type.Slashing], null);
	
	public static Weapon LightPick = new Weapon(
		"Light Pick",24,1,4,
		new Damage(3),new Damage(4),
		new Critical(4),
		0, 3,
		[Type.Piercing], null);
	
	public static Weapon Sap = new Weapon(
		"Sap",25,1,1,
		new Damage(4),new Damage(6),
		new Critical(2),0,2,
		[Type.Bludgeoning], [Special.Nonlethal]);
	
	public static Weapon Starknife = new Weapon(
		"Starknife",26,1,24,
		new Damage(3),new Damage(4),
		new Critical(3),20,3,
		[Type.Piercing], null);
	
	public static Weapon ShortSword = new Weapon(
			"Short Sword",27,1, 10, 
			new Damage(4),new Damage(6),
			new Critical(2,19),
			0,2,
			[Type.Piercing], null);
	

	#endregion

	#region One-Handed Melee Weapons

	public static Weapon Battleaxe = new Weapon(
		"Battleaxe",28,1, 10, 
		new Damage(6),new Damage(8),
		new Critical(3),
		0, 6,
		[Type.Slashing], null);
	
	public static Weapon Flail = new Weapon(
		"Flail",29,1,8,
		new Damage(6),new Damage(8),
		new Critical(2),
		0,5,
		[Type.Bludgeoning], [Special.Disarm, Special.Trip]);
	
	public static Weapon Longsword = new Weapon(
		"Longsword",30,1,15,
		new Damage(6),new Damage(8),
		new Critical(2,19),
		0,4,
		[Type.Slashing], null);
	
	public static Weapon HeavyPick = new Weapon(
		"Heavy Pick",31,1,8
		,new Damage(4),new Damage(6)
		,new Critical(4),
		0,6,
		[Type.Piercing], null);
	
	public static Weapon Rapier = new Weapon(
		"Rapier",32,1,20,
		new Damage(4),new Damage(6),
		new Critical(2,18),
		0, 2,
		[Type.Piercing], null);
	
	public static Weapon Scimitar = new Weapon(
		"Scimitar",33,1, 15, 
		new Damage(4),new Damage(6),
		new Critical(2,18),
		0,4,
		[Type.Slashing], null);
	
	public static Weapon Trident = new Weapon(
		"Trident",34,1, 15, 
		new Damage(6),new Damage(8),
		new Critical(2),
		10, 4,
		[Type.Piercing], [Special.Brace]);
	
	public static Weapon Warhammer = new Weapon(
			"Warhammer",35,1,12, 
			new Damage(6),new Damage(8),
			new Critical(3),
			0,5,
			[Type.Bludgeoning], null);

	#endregion

	#region Two-Handed Melee Weapons

	public static Weapon Falchion = new Weapon(
		"Falchion",36,1,75,
		new Damage(6),new Damage(2,4
			),new Critical(2,18),
		0,8,
		[Type.Slashing], null);
		
    public static Weapon Glaive = new Weapon(
		"Glaive",37,1,8,
		new Damage(8),new Damage(10),
		new Critical(3),
		0,10,
		[Type.Slashing], [Special.Reach]);
	
    public static Weapon Greataxe = new Weapon(
		"Greataxe",38,1,20,
		new Damage(10),new Damage(12),
		new Critical(3),
		0,12,
		[Type.Slashing], null);
	
    public static Weapon Greatclub = new Weapon(
		"Greatclub",39,1,5,
		new Damage(8),new Damage(10),
		new Critical(2),
		0,8,
		[Type.Bludgeoning], null);
	
    public static Weapon HeavyFlail = new Weapon(
		"Heavy Flail",40,1,15,
		new Damage(8),new Damage(10),
		new Critical(2,19),
		0,10,
		[Type.Bludgeoning], [Special.Disarm, Special.Trip]);
	
    public static Weapon Greatsword = new Weapon(
		"Greatsword",41,1,50,
		new Damage(10),new Damage(2,6),
		new Critical(2,19),
		0,8,
		[Type.Slashing], null);
	
    public static Weapon Guisarme = new Weapon(
		"Guisarme",42,1,9,
		new Damage(6),new Damage(2,4),
		new Critical(3),
		0, 12,
		[Type.Slashing], [Special.Reach, Special.Trip]);
	
    public static Weapon Halbred = new Weapon(
		"Halbred",43,1,10,
		new Damage(8),new Damage(10),
		new Critical(3),
		0,12,
		[Type.Piercing, Type.Slashing, Type.Or], [Special.Brace, Special.Trip]);
	
    public static Weapon Lance = new Weapon(
		"Lance",44,1,10,
		new Damage(6),new Damage(8),
		new Critical(3),
		0,10,
		[Type.Piercing], [Special.Reach]);
	
    public static Weapon Ranseur = new Weapon(
		"Ranseur",45,1,10,
		new Damage(6),new Damage(2,4),
		new Critical(3),
		0,12,
		[Type.Piercing], [Special.Disarm, Special.Reach]);
	
    public static Weapon Scythe = new Weapon(
			"Scythe",46,1,18,
			new Damage(6),new Damage(2,4),
			new Critical(4),
			0,10, 
			[Type.Piercing, Type.Slashing, Type.Or], [Special.Trip]);

	#endregion
	
	#region Ranged Weapons
	
	public static RangedWeapon Longbow = new RangedWeapon(
		"Longbow",47,1,75,
		new Damage(6), new Damage(8),
		new Critical(3),
		100,3,
		Munitions.Arrows,
		[Type.Piercing], null);
	
	public static RangedWeapon CompositeLongbow = new RangedWeapon(
		"Composite Longbow",48,1, 100, 
		new Damage(6), new Damage(8),
		new Critical(3),
		110,3,
		Munitions.Arrows,
		[Type.Piercing], null);
	
	public static RangedWeapon Shortbow = new RangedWeapon(
		"Shortbow",49,1,30,
		new Damage(4), new Damage(6),
		new Critical(3),
		60,2,
		Munitions.Arrows,
		[Type.Piercing], null);
	
	public static RangedWeapon CompositeShortbow = new RangedWeapon(
			"Composite Shortbow",50,1,75,
			new Damage(4), new Damage(6),
			new Critical(3),
			70,2,
			Munitions.Arrows,
			[Type.Piercing], null);
	
	#endregion
	
	#endregion
}