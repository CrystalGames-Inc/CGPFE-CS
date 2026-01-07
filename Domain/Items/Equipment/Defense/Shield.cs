namespace Domain.Items.Equipment.Defense;

public class Shield(
    string name,
    int id,
    double cost,
    int shieldBonus,
    int maxDexBonus,
    int armorCheckPenalty,
    int spellFailChance,
    int weight)
    : Item(name, id, cost)
{

    public int ShieldBonus = shieldBonus;
    public int MaxDexBonus = maxDexBonus;
    public int ArmorCheckPenalty = armorCheckPenalty;
    public int SpellFailChance = spellFailChance;
    public int Weight = weight;
}