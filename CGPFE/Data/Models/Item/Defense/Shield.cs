namespace CGPFE.Data.Models.Item.Defense;

public class Shield: Item {

	public int ShieldBonus;
	public int MaxDexBonus;
	public int ArmorCheckPenalty;
	public int SpellFailChance;
	public int Weight;
	
	protected Shield(string name, int id, double cost, int shieldBonus, int maxDexBonus, int armorCheckPenalty, int spellFailChance, int weight) : base(name, id, cost) {
		ShieldBonus = shieldBonus;
		MaxDexBonus = maxDexBonus;
		ArmorCheckPenalty = armorCheckPenalty;
		SpellFailChance = spellFailChance;
		Weight = weight;
	}
}