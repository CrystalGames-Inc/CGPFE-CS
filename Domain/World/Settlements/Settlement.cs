using CGPFE.Domain.World.Geography;
using CGPFE.Domain.World.Settlements;
using CGPFE.Domain.World.Settlements.Properties;
using CGPFE.Core.Enums;
using CGPFE.Core.Utilities;

namespace CGPFE.Domain.World.Settlements;

public class Settlement : Location
{
    #region Properties

    public bool Discovered { get; set; }

    public Info Info;
    public Modifiers Modifiers;
    public Marketplace Marketplace = new Marketplace(0, 0, 0);
    public Location[]? Locations;

    #endregion

    public Settlement(Info info, Modifiers mods, Location[]? locations) : base(info.Name, null, null) {
        Discovered = false;
        Info = info;
        Modifiers = mods;
        if (locations != null)
            Locations = locations;
        CalculateSettlementData();
    }

    #region Checkers

    public bool HasQuality(Quality quality) {
        foreach (Quality q in Modifiers.Qualities) {
            if (q == quality)
                return true;
        }
        return false;
    }

    public bool HasDisadvantage(Disadvantage disadvantage) {
        foreach (Disadvantage d in Modifiers.Disadvantages) {
            if (d == disadvantage)
                return true;
        }
        return false;
    }

    #endregion

    #region Data Calculations

    private void CalculateSettlementData() {
        CalculateDanger();
        CalculateQualitySize();
        CalculateSettlementMarketplace();
        CalculateSettlementModifiers();
    }


    private void CalculateSettlementMarketplace() {
        switch (Info.Type) {
            case Type.Thorpe:
                Marketplace.BaseValue = 50;
                Marketplace.PurchaseLimit = 500;
                Marketplace.Spellcasting = 1;
                Marketplace.MinorMagicItems = new int[Dice.Roll(4)];
                break;
            case Type.Hamlet:
                Marketplace.BaseValue = 200;
                Marketplace.PurchaseLimit = 1000;
                Marketplace.Spellcasting = 2;
                Marketplace.MinorMagicItems = new int[Dice.Roll(6)];
                break;
            case Type.Village:
                Marketplace.BaseValue = 500;
                Marketplace.PurchaseLimit = 2500;
                Marketplace.Spellcasting = 3;
                Marketplace.MinorMagicItems = new int[Dice.Roll(4, 2)];
                Marketplace.MediumMagicItems = new int[Dice.Roll(4)];
                break;
            case Type.SmallTown:
                Marketplace.BaseValue = 1000;
                Marketplace.PurchaseLimit = 5000;
                Marketplace.Spellcasting = 4;
                Marketplace.MinorMagicItems = new int[Dice.Roll(4, 3)];
                Marketplace.MediumMagicItems = new int[Dice.Roll(6)];
                break;
            case Type.LargeTown:
                Marketplace.BaseValue = 2000;
                Marketplace.PurchaseLimit = 10000;
                Marketplace.Spellcasting = 5;
                Marketplace.MinorMagicItems = new int[Dice.Roll(4, 3)];
                Marketplace.MediumMagicItems = new int[Dice.Roll(4, 2)];
                Marketplace.MajorMagicItems = new int[Dice.Roll(4)];
                break;
            case Type.SmallCity:
                Marketplace.BaseValue = 4000;
                Marketplace.PurchaseLimit = 25000;
                Marketplace.Spellcasting = 6;
                Marketplace.MinorMagicItems = new int[Dice.Roll(4, 4)];
                Marketplace.MediumMagicItems = new int[Dice.Roll(4, 3)];
                Marketplace.MajorMagicItems = new int[Dice.Roll(6)];
                break;
            case Type.LargeCity:
                Marketplace.BaseValue = 8000;
                Marketplace.PurchaseLimit = 50000;
                Marketplace.Spellcasting = 7;
                Marketplace.MinorMagicItems = new int[Dice.Roll(4, 4)];
                Marketplace.MediumMagicItems = new int[Dice.Roll(4, 3)];
                Marketplace.MajorMagicItems = new int[Dice.Roll(4, 2)];
                break;
            case Type.Metropolis:
                Marketplace.BaseValue = 16000;
                Marketplace.PurchaseLimit = 100000;
                Marketplace.Spellcasting = 8;
                Marketplace.MinorMagicItems = new int[25];
                Marketplace.MediumMagicItems = new int[Dice.Roll(4, 4)];
                Marketplace.MajorMagicItems = new int[Dice.Roll(4, 3)];
                break;
        }
    }

    private void CalculateDanger() {
        switch (Info.Type) {
            case Type.Thorpe:
                Info.Danger = -4;
                break;
            case Type.Hamlet:
                Info.Danger = -5;
                break;
            case Type.Village:
                Info.Danger = 0;
                break;
            case Type.SmallTown:
                Info.Danger = 0;
                break;
            case Type.LargeTown:
                Info.Danger = 5;
                break;
            case Type.SmallCity:
                Info.Danger = 5;
                break;
            case Type.LargeCity:
                Info.Danger = 10;
                break;
            case Type.Metropolis:
                Info.Danger = 10;
                break;
        }
    }

    private void CalculateQualitySize() {
        Modifiers.Qualities = Info.Type switch {
            Type.Thorpe => new Quality[1],
            Type.Hamlet => new Quality[1],
            Type.Village => new Quality[2],
            Type.SmallTown => new Quality[2],
            Type.LargeTown => new Quality[3],
            Type.SmallCity => new Quality[4],
            Type.LargeCity => new Quality[5],
            Type.Metropolis => new Quality[6],
            _ => Modifiers.Qualities
        };
    }

    private void CalculateSettlementModifiers() {
        CalculateAlignmentModifiers();
        CalculateGovernmentModifiers();
        CalculateQualityModifiers();
        CalculateDisadvantageModifiers();
    }

    private void CalculateGovernmentModifiers() {
        switch (Info.Government) {
            case Government.Colonial:
                Modifiers.Corruption += 2;
                Modifiers.Economy += 1;
                Modifiers.Law += 1;
                break;
            case Government.Council:
                Modifiers.Society += 4;
                Modifiers.Law -= 2;
                Modifiers.Lore -= 2;
                break;
            case Government.Dynasty:
                Modifiers.Corruption += 1;
                Modifiers.Law += 1;
                Modifiers.Society -= 2;
                break;
            case Government.Magical:
                Modifiers.Lore += 2;
                Modifiers.Corruption -= 2;
                Modifiers.Society -= 2;
                Marketplace.Spellcasting -= 1;
                break;
            case Government.Military:
                Modifiers.Law += 3;
                Modifiers.Corruption -= 1;
                Modifiers.Society -= 1;
                break;
            case Government.Overlord:
                Modifiers.Corruption += 2;
                Modifiers.Law += 2;
                Modifiers.Crime -= 2;
                Modifiers.Society -= 2;
                break;
            case Government.SecretSyndicate:
                Modifiers.Corruption += 2;
                Modifiers.Economy += 2;
                Modifiers.Crime += 2;
                Modifiers.Law -= 6;
                break;
            case Government.Plutocracy:
                Modifiers.Corruption += 2;
                Modifiers.Crime += 2;
                Modifiers.Economy += 3;
                Modifiers.Society -= 2;
                break;
            case Government.Utopia:
                Modifiers.Society += 2;
                Modifiers.Lore += 1;
                Modifiers.Corruption -= 2;
                Modifiers.Crime -= 1;
                break;
        }
    }

    private void CalculateQualityModifiers() {
        foreach (Quality q in Modifiers.Qualities) {
            switch (q) {
                case Quality.Abundant:
                    Modifiers.Economy += 1;
                    break;
                case Quality.Abstinent:
                    Modifiers.Corruption += 2;
                    Modifiers.Law += 1;
                    Modifiers.Society -= 2;
                    break;
                case Quality.Academic:
                    Modifiers.Lore += 1;
                    Marketplace.Spellcasting += 1;
                    break;
                case Quality.AdventureSite:
                    Modifiers.Society += 2;
                    Marketplace.PurchaseLimit *= 1.5;
                    break;
                case Quality.AnimalPolyglot:
                    Modifiers.Economy -= 1;
                    Modifiers.Lore += 1;
                    Marketplace.Spellcasting += 1;
                    break;
                case Quality.ArtifactGatherer:
                    Modifiers.Economy += 2;
                    Marketplace.BaseValue /= 2;
                    break;
                case Quality.ArtistColony:
                    Modifiers.Economy += 1;
                    Modifiers.Society += 1;
                    break;
                case Quality.Asylum:
                    Modifiers.Lore += 1;
                    Modifiers.Society -= 2;
                    break;
                case Quality.Broadminded:
                    Modifiers.Lore += 1;
                    Modifiers.Society += 1;
                    break;
                case Quality.DeadCity:
                    Modifiers.Economy -= 2;
                    Modifiers.Lore += 2;
                    Modifiers.Law += 1;
                    break;
                case Quality.CruelWatch:
                    Modifiers.Corruption += 1;
                    Modifiers.Law = 2;
                    Modifiers.Crime -= 3;
                    Modifiers.Society -= 2;
                    break;
                case Quality.Cultured:
                    Modifiers.Society += 1;
                    Modifiers.Law -= 1;
                    break;
                case Quality.DarkVision:
                    Modifiers.Economy += 1;
                    Modifiers.Crime -= 1;
                    break;
                case Quality.Decadent:
                    Modifiers.Corruption += 1;
                    Modifiers.Crime += 1;
                    Modifiers.Economy += 1;
                    Modifiers.Society += 1;
                    Info.Danger += 10;
                    Marketplace.PurchaseLimit *= 1.25;
                    break;
                case Quality.DeepTraditions:
                    Modifiers.Law += 2;
                    Modifiers.Crime -= 2;
                    Modifiers.Society -= 2;
                    break;
                case Quality.Defensible:
                    Modifiers.Corruption += 1;
                    Modifiers.Crime += 1;
                    Modifiers.Economy += 2;
                    Modifiers.Society -= 1;
                    break;
                case Quality.Defiant:
                    Modifiers.Society += 1;
                    Modifiers.Law -= 1;
                    break;
                case Quality.Eldritch:
                    Modifiers.Lore += 2;
                    Info.Danger += 13;
                    Marketplace.Spellcasting += 2;
                    break;
                case Quality.FamedBreeders:
                    Modifiers.Economy += 1;
                    Marketplace.BaseValue *= 1.2;
                    Marketplace.PurchaseLimit *= 1.2;
                    break;
                case Quality.FinancialCenter:
                    Modifiers.Economy += 2;
                    Modifiers.Law += 1;
                    Marketplace.BaseValue *= 1.4;
                    Marketplace.PurchaseLimit *= 1.4;
                    break;
                case Quality.FreeCity:
                    Modifiers.Crime += 2;
                    Info.Danger += 5;
                    Modifiers.Law -= 2;
                    break;
                case Quality.Gambling:
                    Modifiers.Crime += 2;
                    Modifiers.Corruption += 2;
                    Modifiers.Economy += 2;
                    Modifiers.Law -= 1;
                    Marketplace.PurchaseLimit *= 1.1;
                    break;
                case Quality.GodRuled:
                    Modifiers.Corruption -= 2;
                    Modifiers.Society -= 2;
                    break;
                case Quality.GoodRoads:
                    Modifiers.Economy += 2;
                    break;
                case Quality.Guilds:
                    Modifiers.Corruption += 1;
                    Modifiers.Economy += 1;
                    Modifiers.Lore -= 1;
                    break;
                case Quality.HolySite:
                    Modifiers.Corruption -= 2;
                    Marketplace.Spellcasting += 2;
                    break;
                case Quality.Insular:
                    Modifiers.Law += 1;
                    Modifiers.Crime -= 1;
                    break;
                case Quality.Legendarymarketplace:
                    if (Info.Type == Type.Metropolis) {
                        Marketplace.BaseValue *= 2;
                        Marketplace.PurchaseLimit *= 2;
                    }

                    Modifiers.Economy += 2;
                    Modifiers.Crime += 2;
                    break;
                case Quality.LivingForest:
                    Modifiers.Lore += 1;
                    Modifiers.Society += 2;
                    Modifiers.Crime -= 2;
                    Modifiers.Economy -= 4;
                    Marketplace.Spellcasting += 4;
                    break;
                case Quality.MagicallyAttuned:
                    Marketplace.BaseValue *= 1.2;
                    Marketplace.PurchaseLimit *= 1.2;
                    Marketplace.Spellcasting += 2;
                    break;
                case Quality.MagicalPolyglot:
                    Modifiers.Economy += 1;
                    Modifiers.Lore += 1;
                    Modifiers.Society += 1;
                    break;
                case Quality.Majestic:
                    Marketplace.Spellcasting += 1;
                    break;
                case Quality.Militarized:
                    Modifiers.Law += 4;
                    Modifiers.Society -= 4;
                    break;
                case Quality.MobileFrontlines:
                    Modifiers.Corruption -= 1;
                    Modifiers.Economy -= 1;
                    Modifiers.Society -= 1;
                    Marketplace.BaseValue *= 1.25;
                    Marketplace.PurchaseLimit *= 1.25;
                    break;
                case Quality.MobileSanctuary:
                    Modifiers.Economy += 1;
                    Modifiers.Society -= 1;
                    break;
                case Quality.MorallyPermissive:
                    Modifiers.Corruption += 1;
                    Modifiers.Economy += 1;
                    Marketplace.Spellcasting -= 1;
                    break;
                case Quality.MythicSanctum:
                    Modifiers.Corruption -= 2;
                    break;
                case Quality.NoQuestionsAsked:
                    Modifiers.Society += 1;
                    Modifiers.Lore -= 1;
                    break;
                case Quality.Notorious:
                    Modifiers.Crime += 1;
                    Info.Danger += 10;
                    Modifiers.Law -= 1;
                    Marketplace.BaseValue *= 1.3;
                    Marketplace.PurchaseLimit *= 1.5;
                    break;
                case Quality.PeaceBonding:
                    Modifiers.Law += 1;
                    Modifiers.Crime -= 1;
                    break;
                case Quality.Phantasmal:
                    Modifiers.Economy -= 2;
                    Modifiers.Society -= 2;
                    Marketplace.Spellcasting += 2;
                    break;
                case Quality.Pious:
                    Marketplace.Spellcasting += 1;
                    break;
                case Quality.PlanarCrossroads:
                    Modifiers.Crime += 3;
                    Modifiers.Economy += 2;
                    Info.Danger += 20;
                    Marketplace.Spellcasting += 2;
                    Marketplace.PurchaseLimit *= 1.25;
                    break;
                case Quality.PlannedCommunity:
                    Modifiers.Economy += 1;
                    Modifiers.Crime -= 1;
                    Modifiers.Society -= 1;
                    break;
                case Quality.PocketUniverse:
                    Marketplace.Spellcasting += 2;
                    Modifiers.Economy -= 2;
                    break;
                case Quality.PopulationSurge:
                    Modifiers.Crime += 1;
                    Modifiers.Society += 2;
                    break;
                case Quality.Prosperous:
                    Modifiers.Economy += 1;
                    Marketplace.BaseValue *= 1.3;
                    Marketplace.PurchaseLimit *= 1.5;
                    break;
                case Quality.RacialEnclave:
                    Modifiers.Society -= 1;
                    break;
                case Quality.ResettledRuins:
                    Modifiers.Economy += 1;
                    Modifiers.Lore += 1;
                    break;
                case Quality.ReligiousTolerance:
                    Modifiers.Lore += 1;
                    Modifiers.Society += 1;
                    Marketplace.Spellcasting += 2;
                    break;
                case Quality.Restrictive:
                    Modifiers.Corruption -= 1;
                    Modifiers.Lore -= 1;
                    break;
                case Quality.Romantic:
                    Modifiers.Society += 1;
                    break;
                case Quality.RoyalAccommodations:
                    Modifiers.Economy += 1;
                    Modifiers.Law += 2;
                    Modifiers.Society -= 1;
                    break;
                case Quality.RuleOfMight:
                    Modifiers.Law += 2;
                    Modifiers.Society -= 2;
                    break;
                case Quality.RumorMongeringCitizens:
                    Modifiers.Lore += 1;
                    Modifiers.Society -= 1;
                    break;
                case Quality.Rural:
                    Modifiers.Economy -= 1;
                    Modifiers.Crime -= 1;
                    Info.Danger -= 5;
                    break;
                case Quality.SacredAnimals:
                    Modifiers.Lore += 1;
                    Modifiers.Corruption -= 1;
                    Modifiers.Economy -= 1;
                    break;
                case Quality.Sexist:
                    Modifiers.Society -= 2;
                    break;
                case Quality.SlumberingMonster:
                    Modifiers.Lore += 2;
                    Modifiers.Society += 1;
                    Marketplace.Spellcasting += 2;
                    break;
                case Quality.SmallFolkSettlement:
                    Modifiers.Law += 1;
                    Modifiers.Lore += 1;
                    break;
                case Quality.StrategicLocation:
                    Modifiers.Economy += 1;
                    Marketplace.BaseValue *= 1.1;
                    break;
                case Quality.Subterranean:
                    Modifiers.Law += 1;
                    Modifiers.Lore -= 1;
                    Info.Danger -= 5;
                    break;
                case Quality.Superstitious:
                    Modifiers.Law += 2;
                    Modifiers.Society += 2;
                    Modifiers.Crime -= 4;
                    Marketplace.Spellcasting -= 2;
                    break;
                case Quality.Supportive:
                    Modifiers.Society += 2;
                    break;
                case Quality.TimidCitizens:
                    Modifiers.Crime += 2;
                    Modifiers.Lore -= 2;
                    break;
                case Quality.Therapeutic:
                    Modifiers.Economy += 1;
                    Modifiers.Lore += 1;
                    break;
                case Quality.TradingPost:
                    Marketplace.PurchaseLimit *= 2;
                    break;
                case Quality.TouristAttraction:
                    Modifiers.Economy += 1;
                    Marketplace.BaseValue *= 1.2;
                    break;
                case Quality.Unaging:
                    Modifiers.Lore += 4;
                    Modifiers.Society -= 3;
                    Marketplace.Spellcasting += 1;
                    break;
                case Quality.UnderCity:
                    Modifiers.Lore += 1;
                    Info.Danger += 20;
                    break;
                case Quality.UnholySite:
                    Modifiers.Corruption += 2;
                    Marketplace.Spellcasting += 2;
                    break;
                case Quality.WellEducated:
                    Modifiers.Lore += 1;
                    Modifiers.Society += 2;
                    break;
                case Quality.WealthDisparity:
                    //TODO Add poor/rich districts
                    break;
            }
        }
    }

    private void CalculateDisadvantageModifiers() {
        foreach (Disadvantage d in Modifiers.Disadvantages) {
            switch (d) {
                case Disadvantage.Anarchy:
                    Modifiers.Crime += 4;
                    Modifiers.Economy -= 4;
                    Modifiers.Society -= 4;
                    Modifiers.Law -= 6;
                    break;
                case Disadvantage.BureaucraticNightmare:
                    Modifiers.Economy -= 2;
                    Modifiers.Crime += 2;
                    Modifiers.Corruption += 2;
                    break;
                case Disadvantage.Fascistic:
                    Modifiers.Law += 4;
                    Modifiers.Society -= 4;
                    break;
                case Disadvantage.HeavilyTaxed:
                    Modifiers.Society -= 2;
                    Marketplace.BaseValue *= 0.9;
                    Marketplace.PurchaseLimit /= 2;
                    Marketplace.Spellcasting -= 2;
                    break;
                case Disadvantage.Hunted:
                    Modifiers.Economy -= 4;
                    Modifiers.Law -= 4;
                    Modifiers.Society -= 4;
                    Info.Danger += 20;
                    Marketplace.BaseValue *= 0.8;
                    break;
                case Disadvantage.Ignorant:
                    Modifiers.Economy -= 3;
                    Modifiers.Lore -= 6;
                    Modifiers.Society -= 3;
                    break;
                case Disadvantage.Impoverished:
                    Modifiers.Corruption += 1;
                    Modifiers.Crime += 1;
                    Marketplace.BaseValue /= 2;
                    Marketplace.PurchaseLimit /= 2;
                    break;
                case Disadvantage.MagicallyDeadened:
                    Modifiers.Lore -= 1;
                    Modifiers.Economy -= 1;
                    Marketplace.Spellcasting -= 4;
                    break;
                case Disadvantage.MagicalDeadZone:
                    Marketplace.Spellcasting = 0;
                    break;
                case Disadvantage.MartialLaw:
                    Modifiers.Law += 2;
                    Modifiers.Corruption -= 4;
                    Modifiers.Crime -= 2;
                    Modifiers.Economy -= 4;
                    Info.Danger += 10;
                    break;
                case Disadvantage.Oppressed:
                    Modifiers.Lore -= 6;
                    Modifiers.Society -= 6;
                    break;
                case Disadvantage.Plagued:
                    Modifiers.Corruption -= 2;
                    Modifiers.Crime -= 2;
                    Modifiers.Economy -= 2;
                    Modifiers.Law -= 2;
                    Modifiers.Lore -= 2;
                    Modifiers.Society -= 2;
                    Marketplace.BaseValue *= 0.8;
                    break;
                case Disadvantage.RampantInflation:
                    Modifiers.Economy -= 4;
                    Modifiers.Corruption += 2;
                    Modifiers.Crime += 4;
                    break;
                case Disadvantage.Polluted:
                    Modifiers.Corruption += 2;
                    Modifiers.Economy += 4;
                    break;
                case Disadvantage.WildMagicZone:
                    Marketplace.Spellcasting -= 2;
                    break;
            }
        }
    }

    private void CalculateAlignmentModifiers() {
        switch (Info.Alignment) {
            case Alignment.LawfulGood:
                Modifiers.Society += 1;
                Modifiers.Law += 1;
                break;
            case Alignment.NeutralGood:
                Modifiers.Society += 1;
                break;
            case Alignment.ChaoticGood:
                Modifiers.Crime += 1;
                Modifiers.Society += 1;
                break;
            case Alignment.LawfulNeutral:
                Modifiers.Lore += 1;
                Modifiers.Law += 1;
                break;
            case Alignment.Neutral:
                Modifiers.Lore += 2;
                break;
            case Alignment.ChaoticNeutral:
                Modifiers.Crime += 1;
                Modifiers.Lore += 1;
                break;
            case Alignment.LawfulEvil:
                Modifiers.Corruption += 1;
                Modifiers.Law += 1;
                break;
            case Alignment.NeutralEvil:
                Modifiers.Corruption += 1;
                break;
            case Alignment.ChaoticEvil:
                Modifiers.Crime += 1;
                Modifiers.Corruption += 1;
                break;
        }
    }

    #endregion

    #region Data Displays

    public void DisplaySettlementData() {
        DisplaySettlementInfo();
        Console.WriteLine();
        DisplaySettlementMarketplace();
        Console.WriteLine();
        DisplaySettlementModifiers();
    }

    public void DisplaySettlementInfo() {
        Console.WriteLine("Info: ");
        Console.WriteLine(" Name: " + Info.Name);
        if (Info.Nickname != null) Console.WriteLine(" Nickname: " + Info.Nickname);
        Console.WriteLine(" Type: " + Info.Type);
        Console.WriteLine(" Alignment: " + Info.Alignment);
        Console.WriteLine(" Danger: " + Info.Danger);
        Console.WriteLine(" Government: " + Info.Government);
        Console.WriteLine(" Population: " + Info.Population);
    }

    public void DisplaySettlementMarketplace() {
        Console.WriteLine("Marketplace: ");
        Console.WriteLine(" Base Value: " + Marketplace.BaseValue);
        Console.WriteLine(" Purchase Limit: " + Marketplace.PurchaseLimit);
        Console.WriteLine(" Spellcasting: " + Marketplace.Spellcasting);
        Console.WriteLine(" Magic Items: ");
        Console.WriteLine("  Amount of minor magic items: " + Marketplace.MinorMagicItems);
        if (Marketplace.MediumMagicItems != null) Console.WriteLine(" Medium Magic Items: " + Marketplace.MediumMagicItems);
        if (Marketplace.MajorMagicItems != null) Console.WriteLine(" Major Magic Items: " + Marketplace.MajorMagicItems);
    }

    public void DisplaySettlementModifiers() {
        Console.WriteLine("Modifiers: ");
        Console.WriteLine(" Corruption: " + Modifiers.Corruption);
        Console.WriteLine(" Crime: " + Modifiers.Crime);
        Console.WriteLine(" Economy: " + Modifiers.Economy);
        Console.WriteLine(" Law: " + Modifiers.Law);
        Console.WriteLine(" Lore: " + Modifiers.Lore);
        Console.WriteLine(" Society: " + Modifiers.Society);

        Console.WriteLine("\n Qualities: ");
        foreach (var q in Modifiers.Qualities) {
            Console.WriteLine("  " + q);
        }

        Console.WriteLine("\n Disadvantages: ");
        foreach (var d in Modifiers.Disadvantages) {
            Console.WriteLine("  " + d);
        }
    }

    #endregion
}
