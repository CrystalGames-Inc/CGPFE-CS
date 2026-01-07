using Domain.Items.Equipment.Defense;

namespace Storage.Items.Equipment.Defense;

public class ArmorExtras
{
    public static readonly ArmorExtra ArmorSpikes = new ArmorExtra(
        "Armor Spikes",
        0,
        50,
        null,
        null,
        10);

    public static readonly ArmorExtra LockedGauntlet = new ArmorExtra(
        "Locked Gauntlet",
        1,
        8,
        null,
        100,
        5);

    public static readonly ArmorExtra ShieldSpikes = new ArmorExtra(
        "Shield Spikes",
        2,
        10,
        null,
        null,
        5);
}