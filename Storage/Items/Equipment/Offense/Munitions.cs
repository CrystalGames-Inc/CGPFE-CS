using Domain.Items.Equipment.Offense;

namespace Storage.Items.Equipment.Offense;

public abstract class Munitions
{
    public static readonly Ammunition? BlowgunDarts = new Ammunition(
        "Blowgun Darts",
        0,
        0.5,
        10,
        0);

    public static readonly Ammunition? CrossbowBolts = new Ammunition(
        "Crossbow Bolts",
        1,
        1,
        10,
        1);

    public static readonly Ammunition SlingBullets = new Ammunition(
        "Sling Bullets",
        2,
        0.1,
        10,
        5);

    public static readonly Ammunition Arrows = new Ammunition(
        "Arrows",
        3,
        1,
        20,
        3);

    public static readonly Ammunition HandCrossbowBolts = new Ammunition(
        "Hand Crossbow Bolts",
        4,
        1,
        10,
        1);

    public static readonly Ammunition RepeatingCrossbowBolts = new Ammunition(
        "Repeating Crossbow Bolts",
        5,
        1,
        5,
        1);

    public static List<Ammunition> Munition = [
        BlowgunDarts,
        CrossbowBolts,
        SlingBullets,
        Arrows,
        HandCrossbowBolts,
        RepeatingCrossbowBolts
    ];
}