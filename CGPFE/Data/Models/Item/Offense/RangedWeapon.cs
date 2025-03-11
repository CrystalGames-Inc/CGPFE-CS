using CGPFE.Data.Models.Item.Offense.Properties;
using Type = CGPFE.Data.Models.Item.Offense.Properties.Type;

namespace CGPFE.Data.Models.Item.Offense;

public class RangedWeapon(
	string name,
	int id,
	int maxCapacity,
	double? cost,
	Damage? damageS,
	Damage? damageM,
	Critical? critical, 
	int? range,
	double? weight,
	Ammunition? ammunition,
	Type[]? type,
	Special[]? special) : 
	Weapon(name, id, maxCapacity, cost, damageS, damageM, critical, range, weight, type, special) {

	public Ammunition? Ammunition = ammunition;
}