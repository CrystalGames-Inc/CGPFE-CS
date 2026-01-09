using Domain.Items.Consumables.Types;

namespace Storage.Items.Consumables;

public static class Foods
{
    public static Food Bread = new Food("Bread", 0, 0.02, 0.5);
    public static Food Caviar = new Food("Caviar", 1, 50);
    public static Food Cheese = new Food("Cheese", 2, 0.1, 0.5);
    public static Food Chocolate = new Food("Chocolate", 3, 5, 0.5);
    public static Food FortuneCookie = new Food("Fortune Cookie", 4, 0.01);
    public static Food Haggis = new Food("Haggis", 5, 0.1, 1);
    public static Food Honey = new Food("Honey", 6, 1, 0.5);
    public static Food IceCream = new Food("Ice Cream", 7, 0.1);
    public static Food MapleSyrup = new Food("Maple Syrup", 8, 1, 0.5);
    public static Food BanquetMeal = new Food("Banquet Meal", 9, 10);
    public static Food GoodMeal = new Food("Meal (Good)", 10, 0.5);
    public static Food CommonMeal = new Food("Meal (Common)", 11, 0.3);
    public static Food PoorMeal = new Food("Meal (Poor)", 12, 0.1);
    public static Food Meat = new Food("Meat", 13, 0.3, 0.5);
    public static Food StreetMeat = new Food("Street Meat", 14, 0.01, 0.5);
    public static Food TrailRations = new Food("Trail Rations", 15, 0.5, 1);
    public static Food DwarvenTrailRations = new Food("Dwarven Trail Rations", 16, 2, 1);
    public static Food ElvenTrailRations = new Food("Elven Trail Rations", 17, 2, 1);
    public static Food GnomeTrailRations = new Food("Gnome Trail Rations", 18, 2, 1);
    public static Food HalflingTrailRations = new Food("Halfling Trail Rations", 19, 2, 0.5);
    public static Food OrcTrailRations = new Food("Orc Trail Rations", 20, 2, 1);
    public static Food WandermealRations = new Food("Wandermeal", 21, 0.01, 0.5);
    public static Food TravelCakeMix = new Food("Travel Cake Mix", 22, 0.1, 1);
    public static Food Yogurt = new Food("Yogurt", 23, 0.1, 0.5);
}
