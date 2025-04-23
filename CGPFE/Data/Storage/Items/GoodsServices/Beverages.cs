using CGPFE.Data.Models.Item.GoodsServices.Types;

namespace CGPFE.Data.Storage.Items.GoodsServices;

public static class Beverages {
	#region Alcoholic Beverages
	
	public static Drink AbsintheGlass = new Drink("Absinthe (Glass)", 0, 3, true);
	public static Drink AbsintheBottle = new Drink("Absinthe (Bottle)", 1, 30, 1, true);
	public static Drink AleGallon = new Drink("Ale (Gallon)", 2, 0.2, true);
	public static Drink AleMug = new Drink("Ale (Mug)", 3, 0.04, true);
	public static Drink DrwarvenStoutAle = new Drink("Drwarven Stout Ale", 4, 0.04, 0.5, true);
	public static Drink LuglurchAleGallon = new Drink("Luglurch Ale (Gallon)", 5, 1, true);
	public static Drink LuglurchAleMug = new Drink("Luglurch Ale (Mug)", 6, 0.4, true);
	public static Drink ApplejackGallon = new Drink("Applejack (Gallon)", 7, 0.4, 8, true);
	public static Drink ApplejackMug = new Drink("Applejack (Mug)", 8, 0.08, 1, true);
	public static Drink Baijiu = new Drink("Baijiu", 9, 10, 2, true);
	public static Drink Bufo = new Drink("Bufo", 10, 1, 2, true);
	public static Drink Cauim = new Drink("Cauim", 11, 1, 2, true);
	public static Drink Godsbrew = new Drink("Godsbrew", 12, 0.05, 0.5, true);
	public static Drink Grog = new Drink("Grog", 13, 0.02, 0.5, true);
	public static Drink Kumis = new Drink("Kumis", 14, 0.5, 1, true);
	public static Drink MeadGallon = new Drink("Mead (Gallon)", 15, 2, 8, true);
	public static Drink MeadMug = new Drink("Mead (Mug)", 16, 0.05, 0.5, true);
	public static Drink LinnormMead = new Drink("Linnorm Mead", 17, 0.05, 0.5, true);
	public static Drink WaspMead = new Drink("Wasp Mead", 18, 400, 2, true);
	public static Drink Polque = new Drink("Polque", 19, 0.1, 0.5, true);
	public static Drink Rumboozle = new Drink("Rumboozle", 20, 0.1, 0.5, true);
	public static Drink Tepache = new Drink("Tepache", 21, 0.05, 0.5, true);
	public static Drink DragonPunchWhiskey = new Drink("Dragon Punch Whiskey", 22, 10, true);
	public static Drink OldlawWhiskey = new Drink("Oldlaw Whiskey", 23, 1, true);
	public static Drink CommonWine = new Drink("Wine (Common)", 24, 0.2, 6, true);
	public static Drink FineWhiskey = new Drink("Wine (Fine)", 25, 10, 1, true);
	public static Drink SangwineWine = new Drink("Sangwine Wine", 26, 200, 2, true);
	public static Drink SealordWine = new Drink("Sealord Wine", 27, 15, 0.5, true);
	
	#endregion
	
	#region Nonalcoholic Beverages

	public static Drink CommonCoffee = new Drink("Coffee (Common)", 28, 0.01, 0.5, false);
	public static Drink ExoticCoffee = new Drink("Coffee (Exotic)", 29, 0.03, 0.5, false);
	public static Drink DesertCoffee = new Drink("Coffee (Desert)", 30, 0.02, 0.5, false);
	public static Drink DragonsBlendCoffee = new Drink("Dragon's Blend Coffee", 31, 1, false);
	public static Drink HybridCoffee = new Drink("Hybrid Coffee", 32, 1, false);
	public static Drink MarchingCoffee = new Drink("Marching Coffee", 33, 1, false);
	public static Drink Milk = new Drink("Milk", 34, 0.05, 0.5, false);
	public static Drink PowderedMilk = new Drink("Powdered Milk", 35, 0.1, 1, false);
	public static Drink Tea = new Drink("Tea", 36, 0.02, 0.5, false);
	public static Drink CeremonialTea = new Drink("Ceremonial Tea", 37, 0.04, 0.5, false);
	public static Drink MedicinalTonic = new Drink("Medicinal Tonic", 38, 10, false);

	#endregion
}