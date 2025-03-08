using CGPFE.Data.Constants;

namespace CGPFE.Data.Models.Item.Defense;

public class Armor: Item {

	public Weight Type;
	public int ArmorBonus;
	public int MaxDexBonus;
	public int ArmorCheckPenalty;
	public int ArcCheckFailChance;
	public int[] Speeds;
	public int Weight;
	
	protected Armor(string name, int id, double cost, Weight type, int armorBonus, int maxDexBonus, int armorCheckPenalty, int arcCheckFailChance, int[] speeds, int weight) : base(name, id, cost) {
		Type = type;
		ArmorBonus = armorBonus;
		MaxDexBonus = maxDexBonus;
		ArmorCheckPenalty = armorCheckPenalty;
		ArcCheckFailChance = arcCheckFailChance;
		Speeds = speeds;
		Weight = weight;
	}
}