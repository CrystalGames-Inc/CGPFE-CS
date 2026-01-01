using CGPFE.Domain.Characters.Common;
using CGPFE.Domain.Characters.Player.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGPFE.Domain.Characters
{
    public class Entity
    {
        public Attributes Attributes { get; set; }
        public CombatInfo? CombatInfo { get; set; }

        public int GetValueForKey(string key) {
            return key.ToUpper() switch {
                "STR" => Attributes.Strength.value,
                "DEX" => Attributes.Dexterity.value,
                "CON" => Attributes.Constitution.value,
                "INT" => Attributes.Intelligence.value,
                "WIS" => Attributes.Wisdom.value,
                "CHA" => Attributes.Charisma.value,
                "BAB" => CombatInfo != null ? CombatInfo.BaseAttackBonus : 0,
                "CMD" => CombatInfo != null ? CombatInfo.CombatManeuverDefense : 0,
                "CMB" => CombatInfo != null ? CombatInfo.CombatManeuverBonus : 0,
                _ => throw new InvalidOperationException($"Unsupported key: {key}"),
            };
        }
    }
}
