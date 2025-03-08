using CGPFE.Data.Models.Item.Weapon.Properties;
using Type = CGPFE.Data.Models.Item.Weapon.Properties.Type;

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
	: Weapon(name, id, maxCapacity, cost, damageS, damageM, range, weight, type, special) {

	public Ammunition Ammunition = ammunition;
}