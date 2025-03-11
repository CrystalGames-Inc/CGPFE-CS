using CGPFE.Data.Models.Item.Defense;

namespace CGPFE.God.War.Combat.Defense;

public class Shields {
	public static Shield Buckler = new Shield(
		"Buckler",
		0,
		5,
		1,
		0,
		-1,
		5,
		5);
	
	public static Shield LightWoodenShield = new Shield(
		"Light Wooden Shield",
		1,
		3,
		1,
		0,
		-1,
		5,
		5);
	
	public static Shield LightSteelShield = new Shield(
		"Light Steel Shield",
		2,
		9,
		1,
		0,
		-1,
		5,
		6);
	
	public static Shield HeavyWoodenShield = new Shield(
		"Heavy Wooden Shield",
		3,
		7,
		2,
		0,
		-2,
		15,
		6);
	
	public static Shield HeavySteelShield = new Shield(
		"Heavy Steel Shield",
		4,
		20,
		2,
		0,
		-2,
		15,
		15);
	
	public static Shield TowerShield = new Shield(
		"Tower Shield",
		5,
		30,
		4,
		2,
		-10,
		50,
		45);
}