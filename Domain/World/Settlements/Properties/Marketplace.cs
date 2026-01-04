namespace CGPFE.Domain.World.Settlements.Properties;

public class Marketplace(int baseValue, int purchaseLimit, int spellcasting)
{
    public double BaseValue { get; set; } = baseValue;
    public double PurchaseLimit { get; set; } = purchaseLimit;
    public int Spellcasting { get; set; } = spellcasting;

    public int[] MinorMagicItems { get; set; }
    public int[]? MediumMagicItems { get; set; }
    public int[]? MajorMagicItems { get; set; }
}