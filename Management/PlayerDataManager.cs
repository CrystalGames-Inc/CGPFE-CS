using Attribute = CGPFE.Core.Enums.Attribute;
using CGPFE.Storage.Items.Equipment.Defense;
using CGPFE.Storage.Items.Equipment.Offense;
using CGPFE.Domain.Characters.Common;
using CGPFE.Domain.Characters.Player;
using CGPFE.Domain.Items.Equipment.Defense;
using CGPFE.Domain.Items.Equipment.Offense;
using CGPFE.Core.Enums;
using CGPFE.Core.Utilities;
using Domain.Characters.Inventory;
using Storage;

namespace CGPFE.Management;

public class PlayerDataManager
{
    public Player Player = new Player();

    private static PlayerDataManager _instance = null;
    private static readonly object Padlock = new object();


    public static PlayerDataManager Instance
    {
        get
        {
            lock (Padlock)
            {
                _instance ??= new PlayerDataManager();
            }
            return _instance;
        }
    }

    #region Player Registration

    public Player RegisterPlayer()
    {
        Player.PlayerInfo.Name = PromptHelper.TextPrompt("Please choose the player's name: ");

        Player.PlayerInfo.Gender = PromptHelper.EnumPrompt<Gender>("Please choose your gender: ");

        RegisterAbilityScores();

        /*__Race registration and its calculations__*/
        Player.PlayerInfo.Race = PromptHelper.EnumPrompt<Race>("Please choose your race: ");
        CalculateRacialBonus();

        /*__Class registration and its follow-up functions__*/
        Player.PlayerInfo.Class = PromptHelper.EnumPrompt<Class>("Please choose your class: ");
        FileManager.CreatePlayerCombatTable();
        CalculateMaxHealth();
        RegisterAlignment();


        RegisterPlayerAge();
        RegisterPlayerWealth();

        //TODO add the rest of the registration & calculation methods here :)

        CalculatePlayerCombatInfo();

        return Player;
    }

    private void RegisterAbilityScores()
    {

        List<int> abilityScores = [];

        switch (GameDataManager.Instance.GameData.AbilityScoreType)
        {
            case AbilityScoreType.Standard:
                for (var i = 0; i < 6; i++)
                {
                    int[] rolls = [
                        Dice.Roll(6),
                        Dice.Roll(6),
                        Dice.Roll(6),
                        Dice.Roll(6)
                    ];
                    abilityScores.Add(rolls.OrderByDescending(x => x).Take(3).Sum());
                }
                break;
            case AbilityScoreType.Classic:
                for (var i = 0; i < 6; i++)
                {
                    int[] rolls = [
                        Dice.Roll(6),
                        Dice.Roll(6),
                        Dice.Roll(6)
                    ];
                    abilityScores.Add(rolls.Sum());
                }
                break;
            case AbilityScoreType.Heroic:
                for (var i = 0; i < 6; i++)
                {
                    int[] rolls = [
                        Dice.Roll(6),
                        Dice.Roll(6),
                        Dice.Roll(6)
                    ];
                    abilityScores.Add(rolls.Sum() + 6);
                }
                break;
        }

        Attribute[] attributeOrder = [
            Attribute.Strength,
            Attribute.Dexterity,
            Attribute.Constitution,
            Attribute.Intelligence,
            Attribute.Wisdom,
            Attribute.Charisma
        ];

        foreach (var attribute in attributeOrder)
        {
            Console.WriteLine("Available scores:");
            for (int i = 0; i < abilityScores.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {abilityScores[i]}");
            }

            int index;
            while (true)
            {
                Console.Write($"\nSelect the index (1-{abilityScores.Count}) of the score to assign to {attribute}: ");
                if (int.TryParse(Console.ReadLine(), out index) &&
                    index >= 1 &&
                    index <= abilityScores.Count)
                {
                    break;
                }
                Console.WriteLine("Invalid index. Please try again.");
            }

            int chosenScore = abilityScores[index - 1];
            abilityScores.RemoveAt(index - 1);

            // Assign the chosen score to the correct property
            switch (attribute)
            {
                case Attribute.Strength:
                    Player.Attributes.Strength = new AbilityScore(chosenScore);
                    break;
                case Attribute.Dexterity:
                    Player.Attributes.Dexterity = new AbilityScore(chosenScore);
                    break;
                case Attribute.Constitution:
                    Player.Attributes.Constitution = new AbilityScore(chosenScore);
                    break;
                case Attribute.Intelligence:
                    Player.Attributes.Intelligence = new AbilityScore(chosenScore);
                    break;
                case Attribute.Wisdom:
                    Player.Attributes.Wisdom = new AbilityScore(chosenScore);
                    break;
                case Attribute.Charisma:
                    Player.Attributes.Charisma = new AbilityScore(chosenScore);
                    break;
            }

            Console.WriteLine($"Assigned {chosenScore} to {attribute}");
        }
    }

    private void RegisterPlayerAge()
    {
        Player.PlayerInfo.Age = Player.PlayerInfo.Race switch
        {
            Race.Dwarf => PromptHelper.RangePrompt("Please choose the player's age", 40, 450),
            Race.Elf => PromptHelper.RangePrompt("Please choose the player's age", 110, 750),
            Race.Gnome => PromptHelper.RangePrompt("Please choose the player's age", 40, 500),
            Race.HalfElf => PromptHelper.RangePrompt("Please choose the player's age", 20, 185),
            Race.HalfOrc => PromptHelper.RangePrompt("Please choose the player's age", 14, 80),
            Race.Halfling => PromptHelper.RangePrompt("Please choose the player's age", 20, 200),
            Race.Human => PromptHelper.RangePrompt("Please choose the player's age", 15, 110),
            _ => Player.PlayerInfo.Age
        };

        CalculateAgeEffects(Player.PlayerInfo.Age);
    }

    private void RegisterPlayerWealth()
    {
        var avg = Player.PlayerInfo.Class switch
        {
            Class.Alchemist => 105,
            Class.Barbarian => 105,
            Class.Bard => 105,
            Class.Cavalier => 175,
            Class.Cleric => 140,
            Class.Druid => 70,
            Class.Fighter => 175,
            Class.Inquisitor => 140,
            Class.Monk => 35,
            Class.Oracle => 105,
            Class.Paladin => 175,
            Class.Ranger => 175,
            Class.Rogue => 140,
            Class.Sorcerer => 70,
            Class.Summoner => 70,
            Class.Witch => 105,
            Class.Wizard => 70
        };


        var ans = PromptHelper.RangePrompt($"Please choose the way you'd like to get your starter wealth (default - average)\n1. Average (Your class's average is {avg})\n. Random", 1, 2);

        Player.Wallet.GoldPieces = ans switch
        {
            1 => avg,
            2 => Player.PlayerInfo.Class switch
            {
                Class.Alchemist => Dice.Roll(6, 3) * 10,
                Class.Barbarian => Dice.Roll(6, 3) * 10,
                Class.Bard => Dice.Roll(6, 3) * 10,
                Class.Cavalier => Dice.Roll(6, 5) * 10,
                Class.Cleric => Dice.Roll(6, 4) * 10,
                Class.Druid => Dice.Roll(6, 2) * 10,
                Class.Fighter => Dice.Roll(6, 5) * 10,
                Class.Inquisitor => Dice.Roll(6, 4) * 10,
                Class.Monk => Dice.Roll(6, 1) * 10,
                Class.Oracle => Dice.Roll(6, 3) * 10,
                Class.Paladin => Dice.Roll(6, 5) * 10,
                Class.Ranger => Dice.Roll(6, 5) * 10,
                Class.Rogue => Dice.Roll(6, 4) * 10,
                Class.Sorcerer => Dice.Roll(6, 2) * 10,
                Class.Summoner => Dice.Roll(6, 2) * 10,
                Class.Witch => Dice.Roll(6, 3) * 10,
                Class.Wizard => Dice.Roll(6, 2) * 10
            }
        };
        Console.WriteLine($"{Player.Wallet.GoldPieces}gp added to your player");
        Console.WriteLine("Would you like to purchase starting gear? [Y/N] (Default - Y):");
        var gear = Console.ReadLine().ToUpper();
        if (gear.Equals("N"))
            return;
        else
        {
            PurchaseStartingWeapons();
        }
    }

    private void RegisterAlignment()
    {
        var alignmentIn = "";
        switch (Player.PlayerInfo.Class)
        {
            case Class.Barbarian:
                {
                    Console.WriteLine("Please Select An Alignment:\nNeutralGood\nChaoticGood\nNeutral\nChaoticNeutral\nNeutralEvil\nChaoticEvil");
                    alignmentIn = Console.ReadLine();

                    Player.PlayerInfo.Alignment = alignmentIn.ToUpper() switch
                    {
                        "NEUTRALGOOD" => Alignment.NeutralGood,
                        "CHAOTICGOOD" => Alignment.ChaoticGood,
                        "NEUTRAL" => Alignment.Neutral,
                        "CHAOTICNEUTRAL" => Alignment.ChaoticNeutral,
                        "NEUTRALEVIL" => Alignment.NeutralEvil,
                        "CHAOTICEVIL" => Alignment.ChaoticEvil,
                        _ => Player.PlayerInfo.Alignment
                    };
                    break;
                }
            case Class.Alchemist:
            case Class.Bard:
            case Class.Cavalier:
            case Class.Cleric:
            case Class.Fighter:
            case Class.Oracle:
            case Class.Ranger:
            case Class.Rogue:
            case Class.Sorcerer:
            case Class.Summoner:
            case Class.Witch:
            case Class.Wizard:
                Console.WriteLine("Please Select An Alignment:\nLawfulGood\nNeutralGood\nChaoticGood\nLawfulNeutral\nNeutral\nChaoticNeutral\nLawfulEvil\nNeutralEvil\nChaoticEvil");
                alignmentIn = Console.ReadLine().ToUpper();
                Player.PlayerInfo.Alignment = alignmentIn switch
                {
                    "LAWFULGOOD" => Player.PlayerInfo.Alignment = Alignment.LawfulGood,
                    "NEUTRALGOOD" => Player.PlayerInfo.Alignment = Alignment.NeutralGood,
                    "CHAOTICGOOD" => Player.PlayerInfo.Alignment = Alignment.ChaoticGood,
                    "LAWFULNEUTRAL" => Player.PlayerInfo.Alignment = Alignment.LawfulNeutral,
                    "NEUTRAL" => Player.PlayerInfo.Alignment = Alignment.Neutral,
                    "CHAOTICNEUTRAL" => Player.PlayerInfo.Alignment = Alignment.ChaoticNeutral,
                    "LAWFULEVIL" => Player.PlayerInfo.Alignment = Alignment.LawfulEvil,
                    "NEUTRALEVIL" => Player.PlayerInfo.Alignment = Alignment.NeutralEvil,
                    "CHAOTICEVIL" => Player.PlayerInfo.Alignment = Alignment.ChaoticEvil,
                    _ => Player.PlayerInfo.Alignment
                };
                break;

            case Class.Druid:
                Console.WriteLine("Please Select An Alignment:\nNeutralGood\nLawfulNeutral\nNeutral\nChaoticNeutral\nNeutralEvil");
                alignmentIn = Console.ReadLine().ToUpper();
                Player.PlayerInfo.Alignment = alignmentIn switch
                {
                    "NEUTRALGOOD" => Player.PlayerInfo.Alignment = Alignment.NeutralGood,
                    "LAWFULNEUTRAL" => Player.PlayerInfo.Alignment = Alignment.LawfulNeutral,
                    "NEUTRAL" => Player.PlayerInfo.Alignment = Alignment.Neutral,
                    "CHAOTICNEUTRAL" => Player.PlayerInfo.Alignment = Alignment.ChaoticNeutral,
                    "NEUTRALEVIL" => Player.PlayerInfo.Alignment = Alignment.NeutralEvil,
                    _ => Player.PlayerInfo.Alignment
                };
                break;

            case Class.Monk:
                Console.WriteLine("Please Select An Alignment:\nLawfulGood\nLawfulNeutral\nLawfulEvil");
                alignmentIn = Console.ReadLine().ToUpper();
                Player.PlayerInfo.Alignment = alignmentIn switch
                {
                    "LAWFULGOOD" => Player.PlayerInfo.Alignment = Alignment.LawfulGood,
                    "LAWFULNEUTRAL" => Player.PlayerInfo.Alignment = Alignment.LawfulNeutral,
                    "LAWFULEVIL" => Player.PlayerInfo.Alignment = Alignment.LawfulEvil,
                };
                break;
            case Class.Paladin: Player.PlayerInfo.Alignment = Alignment.LawfulGood; break;
        }
    }

    #endregion

    #region Data Calculations

    private void CalculateRacialBonus()
    {
        while (true)
        {
            switch (Player.PlayerInfo.Race)
            {
                case Race.Dwarf:
                    Player.Attributes.Constitution += 2;
                    Player.Attributes.Wisdom += 2;
                    Player.Attributes.Charisma -= 2;
                    break;
                case Race.Elf:
                    Player.Attributes.Dexterity += 2;
                    Player.Attributes.Intelligence += 2;
                    Player.Attributes.Constitution -= 2;
                    break;
                case Race.Gnome:
                    Player.Attributes.Constitution += 2;
                    Player.Attributes.Charisma += 2;
                    Player.Attributes.Strength -= 2;
                    break;
                case Race.HalfElf:
                case Race.HalfOrc:
                case Race.Human:
                    Console.WriteLine("Choose an attribute to enhance by 2:\n1. Strength\n2. Dexterity\n3. Constitution\n4. Intelligence\n5. Wisdom\n6. Charisma");
                    var ans = Convert.ToInt32(Console.ReadLine());
                    switch (ans)
                    {
                        case 1:
                            Player.Attributes.Strength += 2;
                            break;
                        case 2:
                            Player.Attributes.Dexterity += 2;
                            break;
                        case 3:
                            Player.Attributes.Constitution += 2;
                            break;
                        case 4:
                            Player.Attributes.Intelligence += 2;
                            break;
                        case 5:
                            Player.Attributes.Wisdom += 2;
                            break;
                        case 6:
                            Player.Attributes.Charisma += 2;
                            break;
                        default:
                            continue;
                    }

                    break;
                case Race.Halfling:
                    Player.Attributes.Dexterity += 2;
                    Player.Attributes.Charisma += 2;
                    Player.Attributes.Strength -= 2;
                    break;
            }

            break;
        }
    }

    private void CalculatePlayerCombatInfo()
    {
        CalculateArmorClass();
        CalculateCombatManeuverBonus();
        CalculateCombatManeuverDefense();
    }

    private void CalculateArmorClass()
    {
        var ac = 10;

        if (Player.Inventory.Equipped.Armor != string.Empty)
        {
            Armor? armor = StorageNavigator.GetMatchingItem(Player.Inventory.Equipped.Armor, Armors.armors);
            ac += armor == null ? 0 : armor.ArmorBonus;
        }

        if (Player.Inventory.Equipped.Shield != string.Empty)
        {
            Shield? shield = StorageNavigator.GetMatchingItem(Player.Inventory.Equipped.Shield, Shields.shields);
            ac += shield == null ? 0 : shield.ShieldBonus;
        }

        ac += Player.Attributes.Dexterity.Modifier;
        ac += Player.Attributes.SizeMod;

        Player.CombatInfo.ArmorClass = ac;
    }

    private void CalculateCombatManeuverBonus()
    {
        var cmb = 0;

        cmb += Player.CombatInfo.BaseAttackBonus;
        cmb += Player.Attributes.Strength.Modifier;
        cmb += Player.Attributes.SizeMod;

        Player.CombatInfo.CombatManeuverBonus = cmb;
    }

    private void CalculateCombatManeuverDefense()
    {
        var cmd = 10;

        cmd += Player.CombatInfo.BaseAttackBonus;
        cmd += Player.Attributes.Strength.Modifier;
        cmd += Player.Attributes.Dexterity.Modifier;
        cmd += Player.Attributes.SizeMod;

        Player.CombatInfo.CombatManeuverDefense = cmd;
    }

    private void CalculateMaxHealth()
    {
        Player.CombatInfo.MaxHealth = Player.PlayerInfo.Class switch
        {
            Class.Alchemist => 9 + Player.Attributes.Constitution.Modifier,
            Class.Barbarian => 13 + Player.Attributes.Constitution.Modifier,
            Class.Bard => 9 + Player.Attributes.Constitution.Modifier,
            Class.Cavalier => 11 + Player.Attributes.Constitution.Modifier,
            Class.Cleric => 9 + Player.Attributes.Constitution.Modifier,
            Class.Druid => 9 + Player.Attributes.Constitution.Modifier,
            Class.Fighter => 11 + Player.Attributes.Constitution.Modifier,
            Class.Inquisitor => 9 + Player.Attributes.Constitution.Modifier,
            Class.Monk => 9 + Player.Attributes.Constitution.Modifier,
            Class.Oracle => 9 + Player.Attributes.Constitution.Modifier,
            Class.Paladin => 11 + Player.Attributes.Constitution.Modifier,
            Class.Ranger => 11 + Player.Attributes.Constitution.Modifier,
            Class.Rogue => 9 + Player.Attributes.Constitution.Modifier,
            Class.Sorcerer => 7 + Player.Attributes.Constitution.Modifier,
            Class.Summoner => 9 + Player.Attributes.Constitution.Modifier,
            Class.Witch => 7 + Player.Attributes.Constitution.Modifier,
            Class.Wizard => 7 + Player.Attributes.Constitution.Modifier
        };
    }

    private void CalculateAgeEffects(int age)
    {
        switch (Player.PlayerInfo.Race)
        {
            case Race.Dwarf:
                if (age is >= 125 and < 188)
                    ChangePlayerAttributes(-1, -1, -1, 1, 1, 1);
                else if (age is >= 188 and < 250)
                    ChangePlayerAttributes(-2, -2, -2, 1, 1, 1);
                else
                    ChangePlayerAttributes(-3, -3, -3, 1, 1, 1);
                break;
            case Race.Elf:
                if (age is >= 175 and < 263)
                    ChangePlayerAttributes(-1, -1, -1, 1, 1, 1);
                else if (age is >= 263 and < 350)
                    ChangePlayerAttributes(-2, -2, -2, 1, 1, 1);
                else
                    ChangePlayerAttributes(-3, -3, -3, 1, 1, 1);
                break;
            case Race.Gnome:
                if (age is >= 100 and < 150)
                    ChangePlayerAttributes(-1, -1, -1, 1, 1, 1);
                else if (age is >= 150 and < 200)
                    ChangePlayerAttributes(-2, -2, -2, 1, 1, 1);
                else
                    ChangePlayerAttributes(-3, -3, -3, 1, 1, 1);
                break;
            case Race.HalfElf:
                if (age is >= 62 and < 93)
                    ChangePlayerAttributes(-1, -1, -1, 1, 1, 1);
                else if (age is >= 93 and < 125)
                    ChangePlayerAttributes(-2, -2, -2, 1, 1, 1);
                else
                    ChangePlayerAttributes(-3, -3, -3, 1, 1, 1);
                break;
            case Race.HalfOrc:
                if (age is >= 30 and < 45)
                    ChangePlayerAttributes(-1, -1, -1, 1, 1, 1);
                else if (age is >= 45 and < 60)
                    ChangePlayerAttributes(-2, -2, -2, 1, 1, 1);
                else
                    ChangePlayerAttributes(-3, -3, -3, 1, 1, 1);
                break;
            case Race.Halfling:
                if (age is >= 50 and < 75)
                    ChangePlayerAttributes(-1, -1, -1, 1, 1, 1);
                else if (age is >= 75 and < 100)
                    ChangePlayerAttributes(-2, -2, -2, 1, 1, 1);
                else
                    ChangePlayerAttributes(-3, -3, -3, 1, 1, 1);
                break;
            case Race.Human:
                if (age is >= 35 and < 53)
                    ChangePlayerAttributes(-1, -1, -1, 1, 1, 1);
                else if (age is >= 53 and < 70)
                    ChangePlayerAttributes(-2, -2, -2, 1, 1, 1);
                else
                    ChangePlayerAttributes(-3, -3, -3, 1, 1, 1);
                break;
        }
    }

    private void ChangePlayerAttributes(int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
    {
        Player.Attributes.Strength     += strength;
        Player.Attributes.Dexterity    += dexterity;
        Player.Attributes.Constitution += constitution;
        Player.Attributes.Intelligence += intelligence;
        Player.Attributes.Wisdom       += wisdom;
        Player.Attributes.Charisma     += charisma;
    }
    #endregion

    #region Initial item purchase

    private void PurchaseStartingWeapons()
    {
        List<Weapon> purchasableWeapons = [];
        purchasableWeapons.AddRange(Weapons.weapons.Where(weapon => weapon.Cost <= Player.Wallet.GoldPieces));

        Console.WriteLine("Available Weapons:");
        for (var i = 1; i <= purchasableWeapons.Count; i++)
            Console.WriteLine($"{i}. {purchasableWeapons[i - 1].Name.PadRight(25)} - {purchasableWeapons[i - 1].Cost}gp");


        while (true)
        {
            Console.WriteLine("Please enter the index of the weapon you'd like to purchase (0 to advance to armors): ");
            var ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 0)
            {
                PurchaseStartingArmor();

            }
            else if (ans > purchasableWeapons.Count)
            {
                Console.WriteLine("Invalid weapon index entered");
                continue;
            }
            else
            {
                Weapon weapon = purchasableWeapons[ans - 1];
                Player.Inventory.Weapons.Add(new InventoryItem(weapon.Name));
                Player.Wallet.GoldPieces -= weapon.Cost;
                Player.Inventory.Equipped.Weapon = weapon.Name;
            }

            if (PromptHelper.YesNoPrompt("Would you like to purchase another weapon? ", true))
                PurchaseStartingWeapons();
            if (PromptHelper.YesNoPrompt("Would you like to purchase armor/shields? ", true))
                PurchaseStartingArmor();

            return;
        }
    }

    private void PurchaseStartingArmor()
    {
        List<Armor> purchasableArmors = [];
        purchasableArmors.AddRange(Armors.armors.Where(armor => armor.Cost <= Player.Wallet.GoldPieces));

        Console.WriteLine("Available Armors:");
        for (var i = 1; i <= purchasableArmors.Count; i++)
            Console.WriteLine($"{i}. {purchasableArmors[i - 1].Name.PadRight(25)} - {purchasableArmors[i - 1].Cost}gp");

        while (true)
        {
            Console.WriteLine("Please enter the index of the armor you'd like to purchase (0 to advance to shields): ");
            var ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 0)
                PurchaseStartingShields();
            else if (ans > purchasableArmors.Count)
            {
                Console.WriteLine("Invalid armor index entered");
                continue;
            }
            else
            {
                Armor armor = purchasableArmors[ans - 1];
                Player.Inventory.Armors.Add(new InventoryItem(armor.Name));
                Player.Wallet.GoldPieces -= armor.Cost;
                Player.Inventory.Equipped.Armor = armor.Name;
            }


            if (PromptHelper.YesNoPrompt("Would you like to purchase another armor? ", true))
                PurchaseStartingArmor();
            if (PromptHelper.YesNoPrompt("Would you like to purchase shield? ", true))
                PurchaseStartingShields();

            return;
        }
    }

    private void PurchaseStartingShields()
    {
        List<Shield> purchasableShields = [];
        purchasableShields.AddRange(Shields.shields.Where(shield => shield.Cost <= Player.Wallet.GoldPieces));

        Console.WriteLine("Available Shields:");
        for (var i = 1; i <= purchasableShields.Count; i++)
            Console.WriteLine($"{i}. {purchasableShields[i - 1].Name.PadRight(25)} - {purchasableShields[i - 1].Cost}gp");

        while (true)
        {
            Console.WriteLine("Please enter the index of the shield you'd like to purchase (0 to leave): ");
            var ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 0)
                return;
            if (ans > purchasableShields.Count)
            {
                Console.WriteLine("Invalid shield index entered");
                continue;
            }
            {
                Shield shield = purchasableShields[ans - 1];
                Player.Inventory.Shields.Add(new InventoryItem(shield.Name));
                Player.Wallet.GoldPieces -= shield.Cost;
                Player.Inventory.Equipped.Shield = shield.Name;
            }

            if (!PromptHelper.YesNoPrompt("Would you like to purchase another shield? ", true))
                return;
        }
    }

    #endregion
}
