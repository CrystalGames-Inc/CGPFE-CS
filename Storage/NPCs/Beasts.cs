using CGPFE.Domain.Characters.Common;
using CGPFE.Domain.Characters.NPC;
using CGPFE.Domain.Characters.NPC.Properties;
using CGPFE.Domain.Characters.Skill;
using CGPFE.Storage.Items.Equipment.Offense;
using CGPFE.Storage.Skills;
using CGPFE.Core.Enums;
using Domain.Characters.Inventory;
namespace CGPFE.Storage.NPCs;

public static class Beasts
{
    public static NPC Goblin = new NPC
    {
        Info = new NPCInfo()
        {
            Name = "Goblin",
            Feats = ["Improved Initiative"],
            SkillBonuses = new Dictionary<string, int>()
            {
                { "Ride", 10 },
                { "Stealth", 10 },
                { "Swim", 4 },
                { "Perception", -1 }
            },
            Class = NpcClass.Warrior,
            Level = 1,
            XP = 135,
            CR = 0.3f,
            Alignment = Alignment.NeutralEvil
        },
        Attributes = new Attributes()
        {
            Strength = new AbilityScore(11),
            Dexterity = new AbilityScore(15),
            Constitution = new AbilityScore(12),
            Intelligence = new AbilityScore(10),
            Wisdom = new AbilityScore(9),
            Charisma = new AbilityScore(6),
            MoveSpeed = 30,
            Size = Size.Small
        },
        CombatInfo = new CombatInfo()
        {
            ArmorClass = 16,
            MaxHealth = 6,
            Fortitude = 3,
            Reflex = 2,
            Will = -1,
            CombatManeuverBonus = 0,
            CombatManeuverDefense = 12,
            BaseAttackBonus = 1
        },
        Inventory = new Inventory
        {
            Weapons = new List<InventoryItem>
            {
                new InventoryItem(Weapons.ShortSword.Name),
                new InventoryItem(Weapons.Shortbow.Name)
            }
        }
    };
}