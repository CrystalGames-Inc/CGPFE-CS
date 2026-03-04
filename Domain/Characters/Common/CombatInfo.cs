using Attribute = CGPFE.Core.Enums.Attribute;
using CGPFE.Core.Enums;
using CGPFE.Domain.Combat.Action;

namespace CGPFE.Domain.Characters.Common;

public class CombatInfo
{
    public int MaxHealth { get; set; }
    public int Health { get; set; }
    public int ArmorClass { get; set; }
    public int Fortitude { get; set; }
    public int Reflex { get; set; }
    public int Will { get; set; }
    public int BaseAttackBonus { get; set; }
    public Attribute CmbCalcBonus { get; set; }
    public int CombatManeuverBonus { get; set; }
    public int CombatManeuverDefense { get; set; }
    public int ActionCount { get; set; }
    public int SwiftActionCount { get; set; }

    public CombatInfo() {
        ArmorClass = 0;
        Fortitude = 0;
        Reflex = 0;
        Will = 0;
        BaseAttackBonus = 0;
        CmbCalcBonus = Attribute.Strength;
        CombatManeuverBonus = 0;
        CombatManeuverDefense = 0;
    }
}
