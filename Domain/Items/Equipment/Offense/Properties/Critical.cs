using CGPFE.Domain.Items.Equipment.Offense.Properties;

namespace CGPFE.Domain.Items.Equipment.Offense.Properties;


/// <summary> The configuration of a critical damage for a weapon.</summary>
public class Critical(int multiplier, int minDie)
{
    /// <summary>
    /// The damage multiplier if the critical hit is successful. A 2 is double damage.
    /// </summary>
    public int Multiplier = multiplier;
    /// <summary>
    /// The minimum die roll required to pose a threat for a critical hit. Default is 20.
    /// </summary>
    public int MinDie = minDie;

    public Critical(int multiplier) : this(multiplier, 20) {
    }
}
