using CGPFE.Domain.Characters.Common;

namespace CGPFE.Domain.Characters.Common;

public class Attributes
{
    public AbilityScore Strength { get; set; }
    public AbilityScore Dexterity { get; set; }
    public AbilityScore Constitution { get; set; }
    public AbilityScore Intelligence { get; set; }
    public AbilityScore Wisdom { get; set; }
    public AbilityScore Charisma { get; set; }
    public AbilityScore MoveSpeed { get; set; }

    public Attributes() {
        Strength = new AbilityScore(0);
        Dexterity = new AbilityScore(0);
        Constitution = new AbilityScore(0);
        Intelligence = new AbilityScore(0);
        Wisdom = new AbilityScore(0);
        Charisma = new AbilityScore(0);
        MoveSpeed = new AbilityScore(30);
    }
}
