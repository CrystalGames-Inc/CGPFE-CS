using CGPFE.Core.Enums;
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
    public AbilityScore Initiative { get; set; }
    public int MoveSpeed { get; set; }
    public Size Size { get; set; }
    public int SizeMod => Size switch
    {
        Size.Fine => 8,
        Size.Diminutive => 4,
        Size.Tiny => 2,
        Size.Small => 1,
        Size.Medium => 0,
        Size.Large => -1,
        Size.Huge => -2,
        Size.Gargantuan => -4,
        Size.Colossal => -8
    };
    public Attributes() {
        Strength = new AbilityScore(0);
        Dexterity = new AbilityScore(0);
        Constitution = new AbilityScore(0);
        Intelligence = new AbilityScore(0);
        Wisdom = new AbilityScore(0);
        Charisma = new AbilityScore(0);
        MoveSpeed = 30;
    }
}
