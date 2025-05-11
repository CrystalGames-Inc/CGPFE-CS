using CGPFE.Data.Models.Item.Equipment.Offense;
using CGPFE.Data.Models.Item.Equipment.Offense.Properties;
using Type = CGPFE.Data.Models.Item.Equipment.Offense.Properties.Type;

namespace CGPFE.Data.Storage.Items.Equipment.Offense;

public abstract class Weapons {
	#region Simple Weapons

	#region Unarmed Attacks

	public static readonly Weapon Gauntlet = new Weapon("Gauntlet", 0, 1, 2, 
		new Damage(2), new Damage(3), 
		new Critical(2),
		0, 1, 
		[Type.Bludgeoning], null);

	public static readonly Weapon UnarmedStrike = new Weapon("Unarmed Strike", 1, 1, 0, 
		new Damage(2), new Damage(3), 
		new Critical(2),
		0, 0, 
		[Type.Bludgeoning], [Special.Nonlethal]);

	#endregion
	
	#region Light Melee Weapons

	public static readonly Weapon Dagger = new Weapon(
		"Dagger", 2, 1, 2, 
		new Damage(3), new Damage(4), 
		new Critical(2, 19), 
		10, 1, 
		[Type.Piercing, Type.Slashing, Type.Or], null);

	public static readonly Weapon PunchingDagger = new Weapon(
		"Punching Dagger", 3, 1, 2, 
		new Damage(3), new Damage(4), 
		new Critical(3), 
		0, 1, 
		[Type.Piercing], null);
	
	public static readonly Weapon SpikedGauntlet = new Weapon(
		"Spiked Gauntlet",4,1,5, 
		new Damage(3), new Damage(4), 
		new Critical(2), 
		0,1,
		[Type.Piercing], null);
	
	public static readonly Weapon LightMace = new Weapon(
		"Light Mace",5,1,5,
		new Damage(4), new Damage(5),
		new Critical(2),
		0,4,
		[Type.Bludgeoning], null);

	public static readonly Weapon Sickle = new Weapon(
		"Sickle", 6, 1, 6,
		new Damage(4), new Damage(6),
		new Critical(2),
		0, 2,
		[Type.Slashing], [Special.Trip]);

	#endregion
	
	#region One-Handed Melee Weapons
	
	public static readonly Weapon Club = new Weapon(
		"Club",7,1,0, 
		new Damage(4),new Damage(6),
		new Critical(2),
		10,3, 
		[Type.Bludgeoning], null);
	
	public static readonly Weapon HeavyMace = new Weapon(
		"Heavy Mace",8,1,12,
		new Damage(6),new Damage(8),
		new Critical(2),
		0,3, 
		[Type.Bludgeoning], null);
	
	public static readonly Weapon Morningstar = new Weapon(
		"Morningstar",9,1, 8, 
		new Damage(6), new Damage(8), 
		new Critical(2),
		0,6,
		[Type.Bludgeoning, Type.Piercing, Type.And], null);
	
	public static readonly Weapon Shortspear = new Weapon(
			"Shortspear",10,1, 1, 
			new Damage(4), new Damage(6),
			new Critical(2),
			20, 3, 
			[Type.Piercing], null);
	
	#endregion
	
	#region Two-Handed Melee Weapons
	
	public static readonly Weapon Longspear = new Weapon(
		"Longspear",11,1, 5, 
		new Damage(6), new Damage(8), 
		new Critical(3),
		0, 9, 
		[Type.Bludgeoning], [Special.Brace, Special.Reach]);
	
	public static readonly Weapon Quarterstaff = new Weapon(
		"Quarterstaff",12,1,0, 
		new Damage(4),new Damage(6),
		new Critical(2),
		0, 4, 
		[Type.Bludgeoning], [Special.Double, Special.Monk]);
	
	public static readonly Weapon Spear = new Weapon(
			"Spear", 13,1,2, 
			new Damage(6),new Damage(8),
			new Critical(3),
			20,6,
			[Type.Piercing], [Special.Brace]);
	
	#endregion
	
	#region Ranged Weapons
	
	public static readonly RangedWeapon Blowgun = new RangedWeapon(
		"Blowgun",14,1, 2, 
		new Damage(1),new Damage(2),
		new Critical(2),
		20,1, 
		Munitions.BlowgunDarts, 
		[Type.Piercing], null);
	
	public static readonly RangedWeapon HeavyCrossbow = new RangedWeapon(
		"Heavy Crossbow",15,1, 50,
		new Damage(8),new Damage(10),
		new Critical(2,19),
		120,8,
		Munitions.CrossbowBolts,
		[Type.Piercing], null);
	
	public static readonly RangedWeapon LightCrossbow = new RangedWeapon(
		"Light Crossbow",16,1, 30,
		new Damage(6),new Damage(8),
		new Critical(2,19),
		80, 4,
		Munitions.CrossbowBolts,
		[Type.Piercing], null);
	
	public static readonly RangedWeapon Dart = new RangedWeapon(
		"Dart",17,1, 0.5,
		new Damage(3), new Damage(4),
		new Critical(2),
		20, 0.5,
		null,
		[Type.Piercing], null);
	
	public static readonly RangedWeapon Javelin = new RangedWeapon(
		"Javelin",18,1,1,
		new Damage(4),new Damage(6),
		new Critical(2),
		30,2,
		null,
		[Type.Piercing], null);
	
	public static readonly RangedWeapon Sling = new RangedWeapon(
		"Sling",19,1,0,
		new Damage(3),new Damage(4),
		new Critical(2),
		50, 0.0,
		Munitions.SlingBullets,
		[Type.Bludgeoning], null);
	
	#endregion

	public static List<Weapon> SimpleWeapons = [
		Gauntlet,
		Dagger,
		PunchingDagger,
		SpikedGauntlet,
		LightMace,
		Sickle,
		Club,
		HeavyMace,
		Morningstar,
		Shortspear,
		Longspear,
		Quarterstaff,
		Spear,
		Blowgun,
		HeavyCrossbow,
		LightCrossbow,
		Dart,
		Javelin,
		Sling
	];
	
	#endregion
	
	#region Martial Weapons

	#region Light Melee Weapons

	public static readonly Weapon ThrowingAxe = new Weapon(
		"Throwing axe",20,1,8, 
		new Damage(4),new Damage(6), 
		new Critical(2),
		10, 2,
		[Type.Slashing], null);
	
	public static readonly Weapon LightHammer = new Weapon(
		"Light Hammer",21,1,1, 
		new Damage(3),new Damage(4), 
		new Critical(2),
		20, 2,
		[Type.Bludgeoning], null);
	
	public static readonly Weapon Handaxe = new Weapon(
		"Handaxe",22,1,6,
		new Damage(4),new Damage(6),
		new Critical(3),
		0,3,
		[Type.Slashing], null);
	
	public static readonly Weapon Kukri = new Weapon(
		"Kukri",23,1,8,
		new Damage(3),new Damage(4),
		new Critical(2,18),
		0,2,
		[Type.Slashing], null);
	
	public static readonly Weapon LightPick = new Weapon(
		"Light Pick",24,1,4,
		new Damage(3),new Damage(4),
		new Critical(4),
		0, 3,
		[Type.Piercing], null);
	
	public static readonly Weapon Sap = new Weapon(
		"Sap",25,1,1,
		new Damage(4),new Damage(6),
		new Critical(2),0,2,
		[Type.Bludgeoning], [Special.Nonlethal]);
	
	public static readonly Weapon Starknife = new Weapon(
		"Starknife",26,1,24,
		new Damage(3),new Damage(4),
		new Critical(3),20,3,
		[Type.Piercing], null);
	
	public static readonly Weapon ShortSword = new Weapon(
			"Short Sword",27,1, 10, 
			new Damage(4),new Damage(6),
			new Critical(2,19),
			0,2,
			[Type.Piercing], null);
	

	#endregion

	#region One-Handed Melee Weapons

	public static readonly Weapon Battleaxe = new Weapon(
		"Battleaxe",28,1, 10, 
		new Damage(6),new Damage(8),
		new Critical(3),
		0, 6,
		[Type.Slashing], null);
	
	public static readonly Weapon Flail = new Weapon(
		"Flail",29,1,8,
		new Damage(6),new Damage(8),
		new Critical(2),
		0,5,
		[Type.Bludgeoning], [Special.Disarm, Special.Trip]);
	
	public static readonly Weapon Longsword = new Weapon(
		"Longsword",30,1,15,
		new Damage(6),new Damage(8),
		new Critical(2,19),
		0,4,
		[Type.Slashing], null);
	
	public static readonly Weapon HeavyPick = new Weapon(
		"Heavy Pick",31,1,8
		,new Damage(4),new Damage(6)
		,new Critical(4),
		0,6,
		[Type.Piercing], null);
	
	public static readonly Weapon Rapier = new Weapon(
		"Rapier",32,1,20,
		new Damage(4),new Damage(6),
		new Critical(2,18),
		0, 2,
		[Type.Piercing], null);
	
	public static readonly Weapon Scimitar = new Weapon(
		"Scimitar",33,1, 15, 
		new Damage(4),new Damage(6),
		new Critical(2,18),
		0,4,
		[Type.Slashing], null);
	
	public static readonly Weapon Trident = new Weapon(
		"Trident",34,1, 15, 
		new Damage(6),new Damage(8),
		new Critical(2),
		10, 4,
		[Type.Piercing], [Special.Brace]);
	
	public static readonly Weapon Warhammer = new Weapon(
			"Warhammer",35,1,12, 
			new Damage(6),new Damage(8),
			new Critical(3),
			0,5,
			[Type.Bludgeoning], null);

	#endregion

	#region Two-Handed Melee Weapons

	public static readonly Weapon Falchion = new Weapon(
		"Falchion",36,1,75,
		new Damage(6),new Damage(2,4
			),new Critical(2,18),
		0,8,
		[Type.Slashing], null);
		
    public static readonly Weapon Glaive = new Weapon(
		"Glaive",37,1,8,
		new Damage(8),new Damage(10),
		new Critical(3),
		0,10,
		[Type.Slashing], [Special.Reach]);
	
    public static readonly Weapon Greataxe = new Weapon(
		"Greataxe",38,1,20,
		new Damage(10),new Damage(12),
		new Critical(3),
		0,12,
		[Type.Slashing], null);
	
    public static readonly Weapon Greatclub = new Weapon(
		"Greatclub",39,1,5,
		new Damage(8),new Damage(10),
		new Critical(2),
		0,8,
		[Type.Bludgeoning], null);
	
    public static readonly Weapon HeavyFlail = new Weapon(
		"Heavy Flail",40,1,15,
		new Damage(8),new Damage(10),
		new Critical(2,19),
		0,10,
		[Type.Bludgeoning], [Special.Disarm, Special.Trip]);
	
    public static readonly Weapon Greatsword = new Weapon(
		"Greatsword",41,1,50,
		new Damage(10),new Damage(2,6),
		new Critical(2,19),
		0,8,
		[Type.Slashing], null);
	
    public static readonly Weapon Guisarme = new Weapon(
		"Guisarme",42,1,9,
		new Damage(6),new Damage(2,4),
		new Critical(3),
		0, 12,
		[Type.Slashing], [Special.Reach, Special.Trip]);
	
    public static readonly Weapon Halbred = new Weapon(
		"Halbred",43,1,10,
		new Damage(8),new Damage(10),
		new Critical(3),
		0,12,
		[Type.Piercing, Type.Slashing, Type.Or], [Special.Brace, Special.Trip]);
	
    public static readonly Weapon Lance = new Weapon(
		"Lance",44,1,10,
		new Damage(6),new Damage(8),
		new Critical(3),
		0,10,
		[Type.Piercing], [Special.Reach]);
	
    public static readonly Weapon Ranseur = new Weapon(
		"Ranseur",45,1,10,
		new Damage(6),new Damage(2,4),
		new Critical(3),
		0,12,
		[Type.Piercing], [Special.Disarm, Special.Reach]);
	
    public static readonly Weapon Scythe = new Weapon(
			"Scythe",46,1,18,
			new Damage(6),new Damage(2,4),
			new Critical(4),
			0,10, 
			[Type.Piercing, Type.Slashing, Type.Or], [Special.Trip]);

	#endregion
	
	#region Ranged Weapons
	
	public static readonly RangedWeapon Longbow = new RangedWeapon(
		"Longbow",47,1,75,
		new Damage(6), new Damage(8),
		new Critical(3),
		100,3,
		Munitions.Arrows,
		[Type.Piercing], null);
	
	public static readonly RangedWeapon CompositeLongbow = new RangedWeapon(
		"Composite Longbow",48,1, 100, 
		new Damage(6), new Damage(8),
		new Critical(3),
		110,3,
		Munitions.Arrows,
		[Type.Piercing], null);
	
	public static readonly RangedWeapon Shortbow = new RangedWeapon(
		"Shortbow",49,1,30,
		new Damage(4), new Damage(6),
		new Critical(3),
		60,2,
		Munitions.Arrows,
		[Type.Piercing], null);
	
	public static readonly RangedWeapon CompositeShortbow = new RangedWeapon(
			"Composite Shortbow",50,1,75,
			new Damage(4), new Damage(6),
			new Critical(3),
			70,2,
			Munitions.Arrows,
			[Type.Piercing], null);
	
	#endregion

	public static readonly List<Weapon> MartialWeapons = [
		ThrowingAxe,
		LightHammer,
		Handaxe,
		Kukri,
		LightPick,
		Sap,
		Starknife,
		ShortSword,
		Battleaxe,
		Flail,
		Longsword,
		HeavyPick,
		Rapier,
		Scimitar,
		Trident,
		Warhammer,
		Falchion,
		Glaive,
		Greataxe,
		Greatclub,
		HeavyFlail,
		Greatsword,
		Guisarme,
		Halbred,
		Lance,
		Ranseur,
		Scythe,
		Longbow,
		CompositeLongbow,
		Shortbow,
		CompositeShortbow
	];
	
	#endregion
	
	#region Exotic Weapons

	#region Light Melee Weapons

	public static readonly Weapon Kama = new Weapon(
		"Kama",51,1,2,
		new Damage(4), new Damage(6),
		new Critical(2),
		0,2,
		[Type.Slashing], [Special.Monk, Special.Trip]);
	
	public static readonly Weapon Nunchaku = new Weapon(
		"Nunchaku",52,1,2,
		new Damage(4),new Damage(6),
		new Critical(2),
		0,2,
		[Type.Bludgeoning], [Special.Disarm, Special.Monk]);
	
	public static readonly Weapon Sai = new Weapon(
		"Sai",53,1,1,
		new Damage(3), new Damage(4),
		new Critical(2),
		0,1, 
		[Type.Bludgeoning], [Special.Disarm, Special.Monk]);
	
	public static readonly Weapon Siangham = new Weapon(
		"Siangham",54,1,3,
		new Damage(4), new Damage(6),
		new Critical(2),
		0,1,
		[Type.Piercing], [Special.Monk]);

	#endregion

	#region One-Handed Melee Weapons

	public static readonly Weapon BastardSword = new Weapon(
		"Bastard sword",55,1,35,
		new Damage(8), new Damage(10),
		new Critical(2,9),
		0, 6,
		[Type.Slashing], null);
	
	public static readonly Weapon DwarvenWaraxe = new Weapon(
		"Dwarven waraxe",56,1,30,
		new Damage(8), new Damage(10),
		new Critical(3),
		0,8,
		[Type.Slashing], null);
	
	public static readonly Weapon Whip = new Weapon(
		"Whip",57,1,1,
		new Damage(2), new Damage(3),
		new Critical(2),
		0,2, 
		[Type.Slashing], [Special.Disarm, Special.Nonlethal, Special.Reach, Special.Trip]);

	#endregion
	
	#region Two-Handed Melee Weapons
	
	public static readonly Weapon OrcDoubleAxe = new Weapon(
		"Orc Double Axe",58,1,60,
		new Damage(6), new Damage(8),
		new Critical(3),
		0,15,
		[Type.Slashing], [Special.Double]);
	
	public static readonly Weapon SpikedChain = new Weapon(
		"Spiked Chain",59,1, 25,
		new Damage(6), new Damage(2,4),
		new Critical(2),0,10,
		[Type.Piercing], [Special.Disarm, Special.Trip]);
	
	public static readonly Weapon ElvenCurveBlade = new Weapon(
		"Elven Curve Blade",60,1,80,
		new Damage(8), new Damage(10),
		new Critical(2,18),
		0,7,
		[Type.Slashing], null);
	
	public static readonly Weapon DireFlail = new Weapon(
		"Dire Flail",61,1,90,
		new Damage(6), new Damage(8),
		new Critical(2),
		0, 10,
		[Type.Bludgeoning], [Special.Disarm, Special.Double, Special.Trip]);
	
	public static readonly Weapon GnomeHookedHammer = new Weapon(
		"Gnome-Hooked Hammer",62,1,20,
		new Damage(6), new Damage(8),
		new Critical(3),
		0,6,
		[Type.Bludgeoning, Type.Piercing, Type.Or], [Special.Double, Special.Trip]);
	
	public static readonly Weapon TwoBladedSword = new Weapon(
		"Two-Bladed Sword",63,1,100,
		new Damage(6), new Damage(8),
		new Critical(2,19),
		0,10,
		[Type.Slashing], [Special.Double]);
	
	public static readonly Weapon DwarvenEngrosh = new Weapon(
		"Dwarven Engrosh",64,1,50,
		new Damage(6), new Damage(8),
		new Critical(3),
		0, 12, 
		[Type.Piercing, Type.Slashing, Type.Or], [Special.Brace, Special.Double]);
	
	#endregion

	#region Ranged Weapons

	public static readonly Weapon Bolas = new Weapon(
		"Bolas",65,1,5,
		new Damage(3), new Damage(4),
		new Critical(2),
		10, 2,
		[Type.Bludgeoning], [Special.Nonlethal, Special.Trip]);
	
	public static readonly RangedWeapon HandCrossbow = new RangedWeapon(
		"Hand Crossbow",66,1,100,
		new Damage(3), new Damage(4),
		new Critical(2,19),
		30,2, 
		Munitions.HandCrossbowBolts,
		[Type.Piercing], null);
	
	public static readonly RangedWeapon RepeatingHeavyCrossbow = new RangedWeapon(
		"Repeating Heavy Crossbow",67,1,400,
		new Damage(8), new Damage(10),
		new Critical(2,19),
		120,12,
		Munitions.RepeatingCrossbowBolts,
		[Type.Piercing], null);
	
	public static readonly RangedWeapon RepeatingLightCrossbow = new RangedWeapon(
		"Repeating Light Crossbow",68,1,250,
		new Damage(6), new Damage(8),
		new Critical(2,19),
		80,6,
		Munitions.RepeatingCrossbowBolts,
		[Type.Piercing], null);
	
	public static readonly Weapon Net = new Weapon(
		"Net",69,1,20,
		null,null,
		null,
		10, 6,
		null, null);
	
	public static readonly Weapon Shuriken = new Weapon(
		"Shuriken",70,1,1,
		new Damage(1), new Damage(2),
		new Critical(2),
		10,0.5,
		[Type.Piercing], [Special.Monk]);
	
	public static readonly RangedWeapon HalflingSlingStaff = new RangedWeapon(
		"Halfling Sling Staff",71,1,20,
		new Damage(6), new Damage(8),
		new Critical(3),
		80,3,
		Munitions.SlingBullets,
		[Type.Bludgeoning], null);

	#endregion

	public static readonly List<Weapon> ExoticWeapons = [
		Kama,
		Nunchaku,
		Sai,
		Siangham,
		BastardSword,
		DwarvenWaraxe,
		Whip,
		OrcDoubleAxe,
		SpikedChain,
		ElvenCurveBlade,
		DireFlail,
		GnomeHookedHammer,
		TwoBladedSword,
		DwarvenEngrosh,
		Bolas,
		HandCrossbow,
		RepeatingHeavyCrossbow,
		RepeatingLightCrossbow,
		Net,
		Shuriken,
		HalflingSlingStaff
	];

	#endregion

	public static List<Weapon> weapons = SimpleWeapons.Concat(MartialWeapons).Concat(ExoticWeapons).ToList();
}