using CGPFE.Data.Models.Item.Offense.Properties;
using Type = CGPFE.Data.Models.Item.Offense.Properties.Type;

namespace CGPFE.Data.Models.Item.Weapon;

public class Weapon: Item{
	public readonly int MaxCapacity;
	public Damage DamageS;
	public Damage DamageM;
	public int? Range;
	public double Weight;
	public Type[]? Type;
	public Special[]? Special;

	protected Weapon(string name, int id, int maxCapacity, double? cost, Damage damageS, Damage damageM, int? range, double? weight, Type[]? type, Special[]? special) : base(name, id, (double)cost!) {
		MaxCapacity = maxCapacity;
		DamageS = damageS;
		DamageM = damageM;
		Range = range;
		Weight = (double)weight!;
		Type = type;
		Type = type;
		Special = special;
	}
}