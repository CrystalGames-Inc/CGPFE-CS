namespace CGPFE.Data.Models.Item.Defense;

public class ArmorExtra: Item {

	public int ArmorCheckPenalty;
	public int ArcSpellFailChance;
	public int WeightMod;
	
	protected ArmorExtra(string name, int id, double cost, int armorCheckPenalty, int arcSpellFailChance, int weightMod) : base(name, id, cost) {
		ArmorCheckPenalty = armorCheckPenalty;
		ArcSpellFailChance = arcSpellFailChance;
		WeightMod = weightMod;
	}
}