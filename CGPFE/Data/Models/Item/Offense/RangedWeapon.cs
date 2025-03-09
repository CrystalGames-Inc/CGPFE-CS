using CGPFE.Data.Models.Item.Offense;
using CGPFE.Data.Models.Item.Offense.Properties;
using Type = CGPFE.Data.Models.Item.Offense.Properties.Type;

namespace CGPFE.Data.Models.Item.Weapon;

public class RangedWeapon(
	string name,
	int id,
	int maxCapacity,
	double? cost,
	Damage damageS,
	Damage damageM,
	int? range,
	double? weight,
	Type[]? type,
	Special[]? special,
	Ammunition ammunition)
	: Offense.Weapon(name, id, maxCapacity, cost, damageS, damageM, range, weight, type, special) {

	public Ammunition Ammunition = ammunition;
}