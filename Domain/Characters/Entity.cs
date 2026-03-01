using CGPFE.Domain.Characters.Common;
using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Player.Properties.Inventory;
using CGPFE.Domain.Items.Equipment.Defense;
using CGPFE.Domain.Items.Equipment.Offense;

namespace CGPFE.Domain.Characters;
    public abstract class Entity
    {
        public Attributes Attributes { get; set; }
        public CombatInfo? CombatInfo { get; set; }
        public Inventory? Inventory { get; set; } = null;

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

        public T? GetMatchingItem<T>(string itemName, List<T> availableItems) where T : class
        {
            if (Inventory == null || string.IsNullOrEmpty(itemName) || availableItems == null) return null;
            var inventoryEntry = Inventory.Weapons?.FirstOrDefault(i =>
                !string.IsNullOrEmpty(i?.Name) &&
                i.Name.Equals(itemName, StringComparison.OrdinalIgnoreCase));
            if (inventoryEntry == null) return null;
            return availableItems.FirstOrDefault(w =>
                !string.IsNullOrEmpty(w?.ToString()) &&
                w.ToString().Equals(inventoryEntry.Name, StringComparison.OrdinalIgnoreCase));
        }
    }