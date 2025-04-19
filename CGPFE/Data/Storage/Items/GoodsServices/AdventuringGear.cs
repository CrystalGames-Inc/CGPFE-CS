using CGPFE.Data.Models.Item.GoodsServices.Types;

namespace CGPFE.Data.Storage.Items.GoodsServices;

public static class AdventureGear {
	#region Comfort and Shelter
	
	public static AdventuringGear CollapsibleBathtub = new AdventuringGear("Collapsible Bathtub", 0, 15, 20);
	public static AdventuringGear Bedroll = new AdventuringGear("Bedroll", 1, 0.1, 5);
	public static AdventuringGear Blanket = new AdventuringGear("Blanket", 2, 0.5, 3);
	public static AdventuringGear FoldingChair = new AdventuringGear("Folding Chair", 3, 2, 10);
	public static AdventuringGear FoldingLadder = new AdventuringGear("Folding Ladder", 4, 2, 16);
	public static AdventuringGear Cot = new AdventuringGear("Cot", 5, 1, 30);
	public static AdventuringGear Hammock = new AdventuringGear("Hammock", 6, 0.1, 3);
	public static AdventuringGear Soap = new AdventuringGear("Soap", 7, 0.01, 0.5);
	public static AdventuringGear SmallTent = new AdventuringGear("Tent (Small)", 8, 10, 20);
	public static AdventuringGear MediumTent = new AdventuringGear("Tent (Medium)", 9, 15, 30);
	public static AdventuringGear LargeTent = new AdventuringGear("Tent (Large)", 10, 30, 40);
	public static AdventuringGear PavilionTent = new AdventuringGear("Pavilion Tent", 11, 100, 50);
	public static AdventuringGear HangingTent = new AdventuringGear("Hanging Tent", 12, 20, 15);

	#endregion
	
	#region Hunting and Fishing Gear
	
	public static AdventuringGear Fishhook = new AdventuringGear("Fishhook", 13, 0.1);
	public static AdventuringGear BellNet = new AdventuringGear("Bell Net", 14, 2, 2);
	public static AdventuringGear ButterflyNet = new AdventuringGear("Butterfly Net", 15, 5, 2);
	public static AdventuringGear CamouflageNet = new AdventuringGear("Camouflage Net", 16, 20, 5);
	public static AdventuringGear FishingNet = new AdventuringGear("Fishing Net", 17, 4, 5);
	public static AdventuringGear ScentCloak = new AdventuringGear("Scent Cloak", 18, 20, 2);
	public static AdventuringGear BearTrap = new AdventuringGear("Bear Trap", 19, 2, 10);
	
	#endregion

	#region Misc. Outdoors Gear

	public static AdventuringGear AirBladder = new AdventuringGear("Air Bladder", 20, 0.1, 0.5);
	public static AdventuringGear AnimalGlue = new AdventuringGear("Animal Glue", 21, 0.5, 0.5);
	public static AdventuringGear AnimalRepellentSack = new AdventuringGear("Animal-Repellent Sack", 22, 1, 0.5);
	public static AdventuringGear CarrierBackpack = new AdventuringGear("Carrier Backpack", 23, 25, 5);
	public static AdventuringGear HydrationBackpack = new AdventuringGear("Hydration Backpack", 24, 40, 4);
	public static AdventuringGear WeaponrackBackpack = new AdventuringGear("Weaponrack Backpack", 25, 25, 5);

	#endregion
}