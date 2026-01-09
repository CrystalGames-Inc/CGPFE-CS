using Domain.Items.Equipment.Offense.Properties;

namespace Domain.Items.Equipment.Offense.Properties;

public class Damage(int die, int amount)
{
    public int Die = die;
    public int Amount = amount;

    public Damage(int die) : this(die, 1) {
    }
}
