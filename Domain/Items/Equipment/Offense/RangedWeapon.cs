using Type = CGPFE.Domain.Items.Equipment.Offense.Properties.Type;
using CGPFE.Domain.Items.Equipment.Offense;
using CGPFE.Domain.Items.Equipment.Offense.Properties;

namespace CGPFE.Domain.Items.Equipment.Offense;

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
    Weapon(name, id, maxCapacity, cost, damageS, damageM, critical, range, weight, type, special)
{

    public Ammunition? Ammunition = ammunition;
}
