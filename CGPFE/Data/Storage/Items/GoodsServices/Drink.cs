using CGPFE.Data.Models.Item.GoodsServices.Types;

namespace CGPFE.Data.Storage.Items.GoodsServices;

public static class Drinks {
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
	public static Drink MeadMug = new Drink("Mead (Mug)", 15, 0.05, 0.5, true);
	public static Drink MeadGallon = new Drink("Mead (Gallon)", 16, 2, 8, true);
}