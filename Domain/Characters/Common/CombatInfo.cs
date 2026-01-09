using Attribute = CGPFE.Core.Enums.Attribute;
using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Common;

public class CombatInfo
{
    public int InitMod { get; set; }
    public int ArmorClass { get; set; }
    public int Fortitude { get; set; }
    public int Reflex { get; set; }
    public int Will { get; set; }
    public int BaseAttackBonus { get; set; }
    public Attribute CmbCalcBonus { get; set; }
    public int CombatManeuverBonus { get; set; }
    public int CombatManeuverDefense { get; set; }

    public CombatInfo() {
        InitMod = 0;
        ArmorClass = 0;
        Fortitude = 0;
        Reflex = 0;
        Will = 0;
        BaseAttackBonus = 0;
        CmbCalcBonus = Attribute.Strength;
        CombatManeuverBonus = 0;
        CombatManeuverDefense = 0;
    }

    public int GetValueForKey(string key) {
        return key.ToUpper() switch {
            "INI" => InitMod,
            "ACL" => ArmorClass,
            "FOR" => Fortitude,
            "REF" => Reflex,
            "WIL" => Will,
            "BAB" => BaseAttackBonus,
            "CMB" => CombatManeuverBonus,
            "CMD" => CombatManeuverDefense,
            _ => throw new NotSupportedException($"Invalid key {key}")
        };
    }
}
