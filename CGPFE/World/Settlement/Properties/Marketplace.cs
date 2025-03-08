namespace CGPFE.World.Settlement.Properties;

public class Marketplace {
	public double BaseValue { get; set; }
	public double PurchaseLimit { get; set; }
	public int Spellcasting { get; set; }

	public Marketplace(int baseValue, int purchaseLimit, int spellcasting) {
		BaseValue = baseValue;
		PurchaseLimit = purchaseLimit;
		Spellcasting = spellcasting;
	}
}