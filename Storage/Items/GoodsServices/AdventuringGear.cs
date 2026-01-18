using CGPFE.Domain.Items.GoodsServices.Types;

namespace Storage.Items.GoodsServices;

public static class AdventureGear
{
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
    public static AdventuringGear Bell = new AdventuringGear("Bell", 26, 1);
    public static AdventuringGear CommonBuoy = new AdventuringGear("Common Buoy", 27, 0.5, 16);
    public static AdventuringGear SuperiorBuoy = new AdventuringGear("Superior Buoy", 28, 10, 30);
    public static AdventuringGear Compass = new AdventuringGear("Compass", 29, 10, 0.5);
    public static AdventuringGear CoolerChest = new AdventuringGear("Cooler Chest", 30, 25, 60);
    public static AdventuringGear CamouflagedCanvas = new AdventuringGear("Camouflaged Canvas", 31, 1, 1);
    public static AdventuringGear DuoSaw = new AdventuringGear("Duo Saw", 32, 100, 20);
    public static AdventuringGear EfficientTent = new AdventuringGear("Efficient Tent", 33, 150, 15);
    public static AdventuringGear FieldSurvivalGuide = new AdventuringGear("Field-Survival Guide", 34, 20, 1);
    public static AdventuringGear GoblinFishingLure = new AdventuringGear("Goblin Fishing Lure", 35, 5);
    public static AdventuringGear Heatstone = new AdventuringGear("Heatstone", 36, 20, 1);
    public static AdventuringGear PowderHorn = new AdventuringGear("Powder Horn", 37, 3, 1);
    public static AdventuringGear SignalHorn = new AdventuringGear("Signal Horn", 38, 1, 2);
    public static AdventuringGear HunterStand = new AdventuringGear("Hunter's Stand", 39, 25, 15);
    public static AdventuringGear InsulatedFlask = new AdventuringGear("Insulated Flask", 40, 0.2, 1);
    public static AdventuringGear Map = new AdventuringGear("Map", 41, 50, 2);
    public static AdventuringGear SmallSteelMirror = new AdventuringGear("Small Steel Mirror", 42, 10, 0.5);
    public static AdventuringGear NatureClimbingHarness = new AdventuringGear("Nature Climbing Harness", 43, 60, 4);
    public static AdventuringGear SilentPiton = new AdventuringGear("Silent Piton", 44, 0.5, 0.5);
    public static AdventuringGear PrivacyShelter = new AdventuringGear("Privacy Shelter", 45, 5, 10);
    public static AdventuringGear HempRope = new AdventuringGear("Hemp Rope (50ft)", 46, 1, 10);
    public static AdventuringGear BloodvineRope = new AdventuringGear("Bloodvine Rope", 47, 200, 5);
    public static AdventuringGear SilkRope = new AdventuringGear("Silk Rope (50ft)", 48, 10, 5);
    public static AdventuringGear SpiderSilkRope = new AdventuringGear("Spider's Silk Rope (50ft)", 49, 100, 4);
    public static AdventuringGear StretchCords = new AdventuringGear("Stretch Cords", 50, 0.5, 0.5);
    public static AdventuringGear TentCover = new AdventuringGear("Tent Cover", 51, 15, 15);
    public static AdventuringGear TrekkingPole = new AdventuringGear("Trekking Pole", 52, 15, 2);
    public static AdventuringGear WindupMusicBox = new AdventuringGear("Windup Music Box", 53, 25, 0.5);
    public static AdventuringGear StarCharts = new AdventuringGear("Star Charts", 54, 200, 0.5);
    public static AdventuringGear String = new AdventuringGear("String", 55, 0.01, 0.5);
    public static AdventuringGear Twine = new AdventuringGear("Twine", 56, 0.01, 0.5);
    public static AdventuringGear Whetstone = new AdventuringGear("Whetstone", 57, 0.02, 1);
    public static AdventuringGear BeastWhistle = new AdventuringGear("Beast Whistle", 58, 5);
    public static AdventuringGear SignalWhistle = new AdventuringGear("Signal Whistle", 59, 0.8);
    public static AdventuringGear SilentWhistle = new AdventuringGear("Silent Whistle", 60, 0.9);

    #endregion

    #region Illuminations

    public static AdventuringGear Candle = new AdventuringGear("Candle", 61, 0.01);
    public static AdventuringGear HelmetCandle = new AdventuringGear("Helmet Candle", 62, 2, 4);
    public static AdventuringGear CandleLamp = new AdventuringGear("Candle Lamp", 63, 5, 1);
    public static AdventuringGear Candlestick = new AdventuringGear("Candlestick", 64, 0.01, 0.5);
    public static AdventuringGear Darkflare = new AdventuringGear("Darkflare", 65, 1);
    public static AdventuringGear Firewood = new AdventuringGear("Firewood", 66, 0.01);
    public static AdventuringGear Lamp = new AdventuringGear("Lamp", 67, 0.01);
    public static AdventuringGear CelestialLamp = new AdventuringGear("Celestial Lamp", 68, 300, 2);
    public static AdventuringGear BullseyeLantern = new AdventuringGear("Bullseye Lantern", 69, 12, 3);
    public static AdventuringGear WaterproofBullseyeLantern = new AdventuringGear("Waterproof Bullseye Lantern", 70, 17);
    public static AdventuringGear DarklightLantern = new AdventuringGear("Darklight Lantern", 71, 20, 2);
    public static AdventuringGear WaterproofDarklightLantern = new AdventuringGear("Waterproof Darklight Lantern", 72, 25);
    public static AdventuringGear HoodedLantern = new AdventuringGear("Hooded Lantern", 73, 7, 2);
    public static AdventuringGear WaterproofHoodedLantern = new AdventuringGear("Waterproof Hooded Lantern", 74, 12);
    public static AdventuringGear MinerLantern = new AdventuringGear("Miner's Lantern", 75, 15, 2);
    public static AdventuringGear WaterproofMinerLantern = new AdventuringGear("Waterproof Miner's Lantern", 76, 20, 2);
    public static AdventuringGear Moonrod = new AdventuringGear("Moonrod", 77, 10, 1);
    public static AdventuringGear LampOil = new AdventuringGear("Lamp Oil", 78, 0.1, 1);
    public static AdventuringGear Sunrod = new AdventuringGear("Sunrod", 79, 2, 1);
    public static AdventuringGear Thurible = new AdventuringGear("Thurible", 80, 50, 3);
    public static AdventuringGear Torch = new AdventuringGear("Torch", 81, 0.01, 1);
    public static AdventuringGear EverburningTorch = new AdventuringGear("Everburning Torch", 82, 110, 1);

    #endregion
}
