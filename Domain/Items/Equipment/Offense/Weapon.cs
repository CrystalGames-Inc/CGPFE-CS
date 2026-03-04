using Type = CGPFE.Domain.Items.Equipment.Offense.Properties.Type;
using CGPFE.Domain.Items;
using CGPFE.Domain.Items.Equipment.Offense.Properties;
using CGPFE.Core.Utilities;
using CGPFE.Domain.Characters;

namespace CGPFE.Domain.Items.Equipment.Offense;

public class Weapon(string name, int id, int maxCapacity, double? cost, Damage? damageS, Damage? damageM, Critical? critical, int? range, double? weight, Type[]? type, Special[]? special)
    : Item(name, id, (double)cost!)
{

    public int MaxCapacity = maxCapacity;
    public Damage? DamageS = damageS;
    public Damage? DamageM = damageM;
    public Critical? Critical = critical;
    public int? Range = range;
    public double? Weight = weight;
    public Type[]? Type = type;
    public Special[]? Special = special;

    public int RollMDamage(Entity target)
    {
        Console.WriteLine("Rolling for hit...");
        int hitDie = Dice.Roll(20);
        Console.WriteLine($"Rolled a {hitDie}");
        if(hitDie == 1)
        {
            Console.WriteLine("Critical Miss!");
            return 0;
        }
        int dealtDamage = Dice.Roll(DamageM.Die, DamageM.Amount);
        if (hitDie >= Critical.MinDie)
        {
            Console.WriteLine("Potential Critical!");
            int critRoll = Dice.Roll(20);
            Console.WriteLine($"Rolled a {critRoll}.");
            if (critRoll > target.CombatInfo.ArmorClass)
            {
                Console.WriteLine("Critical Hit!");
                dealtDamage *= Critical.Multiplier;
            }
            else
                Console.WriteLine("No critical hit!");
        }

        return dealtDamage;
    }

    public int RollSDamage(Entity target)
    {
        Console.WriteLine("Rolling for hit...");
        int hitDie = Dice.Roll(20);
        Console.WriteLine($"Rolled a {hitDie}");
        if (hitDie == 1)
        {
            Console.WriteLine("Critical Miss!");
            return 0;
        }
        int dealtDamage = Dice.Roll(DamageS.Die, DamageS.Amount);
        if (hitDie >= Critical.MinDie)
        {
            Console.WriteLine("Potential Critical!");
            int critRoll = Dice.Roll(20);
            Console.WriteLine($"Rolled a {critRoll}.");
            if (critRoll > target.CombatInfo.ArmorClass)
            {
                Console.WriteLine("Critical Hit!");
                dealtDamage *= Critical.Multiplier;
            }
            else
                Console.WriteLine("No critical hit!");
        }

        return dealtDamage;
    }
}
