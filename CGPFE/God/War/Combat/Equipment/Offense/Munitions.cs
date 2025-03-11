using CGPFE.Data.Models.Item.Offense;

namespace CGPFE.God.War.Combat.Offense;

public class Munitions {
	public static Ammunition? BlowgunDarts = new Ammunition(
		"Blowgun Darts",
		0,
		0.5,
		10,
		0);

	public static Ammunition? CrossbowBolts = new Ammunition(
		"Crossbow Bolts",
		1,
		1,
		10,
		1);

	public static Ammunition SlingBullets = new Ammunition(
		"Sling Bullets",
		2,
		0.1,
		10,
		5);

	public static Ammunition Arrows = new Ammunition(
		"Arrows",
		3,
		1,
		20,
		3);

	public static Ammunition HandCrossbowBolts = new Ammunition(
		"Hand Crossbow Bolts",
		4,
		1,
		10,
		1);

	public static Ammunition RepeatingCrossbowBolts = new Ammunition(
		"Repeating Crossbow Bolts",
		5,
		1,
		5,
		1);
}