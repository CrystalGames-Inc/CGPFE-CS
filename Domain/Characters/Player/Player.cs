using Attribute = CGPFE.Core.Enums.Attribute;
using CGPFE.Domain.Characters.Common;
using CGPFE.Domain.Characters.Player.Properties;
using CGPFE.Domain.Characters.Skill;
using CGPFE.Domain.World.Geography;
using CGPFE.Domain.World.Settlements;
using Domain.Characters.Inventory;
using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Player;

public class Player : Entity
{
    public PlayerInfo PlayerInfo { get; set; } = new();
    public Attributes Attributes { get; set; } = new();
    public CombatInfo CombatInfo { get; set; } = new();
    public List<string> ClassSkills { get; set; } = [];
    public List<string> Feats { get; set; } = [];
    public Inventory Inventory { get; set; } = new();
    public Wallet Wallet = new();
    public List<Language> KnownLanguages { get; set; } = new();

    #region Getters

    public override int GetValueForKey(string key) {
        return key.ToUpper() switch {
            "LVL" => PlayerInfo.Level,
            "CLS" => (int)PlayerInfo.Class,
            "RCE" => (int)PlayerInfo.Race,
            "SZE" => (int)Attributes.Size,
            _ => base.GetValueForKey(key)
        };
    }


    public Skill.Skill? GetMatchingSkill(string skillName, List<Skill.Skill> availableSkills) {
        if (string.IsNullOrEmpty(skillName)) return null;
        return availableSkills.FirstOrDefault(skill => skill.Name.ToUpper().Equals(skillName, StringComparison.OrdinalIgnoreCase));
    }

    #endregion

    public bool HasFeat(string featName) {
        return Feats.Any(playerFeat => playerFeat.ToUpper().Equals(featName, StringComparison.OrdinalIgnoreCase));
    }

    #region Displays

    public void DisplayBasicInfo() {
        Console.WriteLine("Player Info:");
        Console.WriteLine($"  Name: {PlayerInfo.Name}");
        Console.WriteLine($"  Gender: {PlayerInfo.Gender}");
        Console.WriteLine($"  Alignment: {PlayerInfo.Alignment}");
        Console.WriteLine($"  Age: {PlayerInfo.Age}");
        Console.WriteLine($"  Race: {PlayerInfo.Race}");
        Console.WriteLine($"  Size: {Attributes.Size}");
        Console.WriteLine($"  Size Modifier: {Attributes.SizeMod}");
        Console.WriteLine($"  Class: {PlayerInfo.Class}");
        Console.WriteLine($"  Level: {PlayerInfo.Level}");
        Console.WriteLine($"  Current XP: {PlayerInfo.Xp}");
        Console.WriteLine($"  Maximum Health: {CombatInfo.MaxHealth}");
        Console.WriteLine($"  Current Health: {CombatInfo.Health}");
    }

    public void DisplayAttributes() {
        Console.WriteLine("Attributes: ");
        Console.WriteLine($"  Strength: {Attributes.Strength}");
        Console.WriteLine($"  Dexterity: {Attributes.Dexterity}");
        Console.WriteLine($"  Constitution: {Attributes.Constitution}");
        Console.WriteLine($"  Intelligence: {Attributes.Intelligence}");
        Console.WriteLine($"  Wisdom: {Attributes.Wisdom}");
        Console.WriteLine($"  Charisma: {Attributes.Charisma}");
        Console.WriteLine($"  Move Speed: {Attributes.MoveSpeed}");
    }

    public void DisplayAttributeMods() {
        Console.WriteLine("Attribute Modifiers: ");
        Console.WriteLine($"  Strength: {Attributes.Strength.Modifier}");
        Console.WriteLine($"  Dexterity: {Attributes.Dexterity.Modifier}");
        Console.WriteLine($"  Constitution: {Attributes.Constitution.Modifier}");
        Console.WriteLine($"  Intelligence: {Attributes.Intelligence.Modifier}");
        Console.WriteLine($"  Wisdom: {Attributes.Wisdom.Modifier}");
        Console.WriteLine($"  Charisma: {Attributes.Charisma.Modifier}");
    }

    public void DisplayCombatInfo() {
        Console.WriteLine("Combat Info: ");
        Console.WriteLine($"  Init Modifier: {Attributes.Initiative.Modifier}");
        Console.WriteLine($"  Base Attack  {CombatInfo.BaseAttackBonus}");
        Console.WriteLine($"  Fortitude: {CombatInfo.Fortitude}");
        Console.WriteLine($"  Reflex: {CombatInfo.Reflex}");
        Console.WriteLine($"  Will: {CombatInfo.Will}");
        Console.WriteLine($"  CMB: {CombatInfo.CombatManeuverBonus}");
        Console.WriteLine($"  CMD: {CombatInfo.CombatManeuverDefense}");
        Console.WriteLine($"  Armor Class:  {CombatInfo.ArmorClass}");
    }

    public void DisplayWeapons() {
        if (Inventory.Weapons == null) {
            Console.WriteLine("No weapons on character");
        } else {
            Console.WriteLine($"Weapons detected: {Inventory.Weapons.Count}");
            for (var i = 0; i < Inventory.Weapons.Count; ++i) {
                Console.WriteLine($"{i + 1}: {Inventory.Weapons[i].Name}");
            }
        }
    }

    public void DisplayArmors() {
        if (Inventory.Armors == null) {
            Console.WriteLine("No armor on character");
        } else {
            Console.WriteLine($"Armors detected: {Inventory.Armors.Count}");
            for (var i = 0; i < Inventory.Armors.Count; ++i) {
                Console.WriteLine($"{i + 1}: {Inventory.Armors[i].Name}");
            }
        }
    }

    public void DisplayShields() {
        if (Inventory.Shields == null) {
            Console.WriteLine("No shield on character");
        } else {
            Console.WriteLine($"Shields detected: {Inventory.Shields.Count}");
            for (var i = 0; i < Inventory.Shields.Count; ++i) {
                Console.WriteLine($"{i + 1}: {Inventory.Shields[i].Name}");
            }
        }
    }

    public void DisplayWallet() {
        Console.WriteLine("Wallet: ");
        Console.WriteLine($"  Copper: {Wallet.CopperPieces}");
        Console.WriteLine($"  Silver: {Wallet.SilverPieces}");
        Console.WriteLine($"  Gold: {Wallet.GoldPieces}");
        Console.WriteLine($"  Platinum: {Wallet.PlatinumPieces}");
    }

    public void DisplayCurrentLocation() {
        Location? currentLocation = PlayerInfo.CurrentLocation;
        if (currentLocation == null)
            Console.WriteLine("You are now in the abyss, the void. You can see nothing, hear nothing.");
        else if (currentLocation.GetType() == typeof(Region))
            Console.WriteLine($"You are currently in {currentLocation.Name} region, roaming around");
        else if (currentLocation.GetType() == typeof(Settlement))
            Console.WriteLine($"You are currently in the settlement of {currentLocation.Name}, roaming around");
        else if (currentLocation.GetType() == typeof(Location))
            Console.WriteLine($"You are currently in {currentLocation.Name}");
    }

    #endregion
}
