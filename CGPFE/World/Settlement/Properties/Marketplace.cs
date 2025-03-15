namespace CGPFE.World.Settlement.Properties;

public class Marketplace(int baseValue, int purchaseLimit, int spellcasting) {
	public double BaseValue { get; set; } = baseValue;
	public double PurchaseLimit { get; set; } = purchaseLimit;
	public int Spellcasting { get; set; } = spellcasting;
}