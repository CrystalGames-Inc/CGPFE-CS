using Attribute = Core.Enums.Attribute;
using Domain.Characters.Skill;
using Core.Enums;

namespace Domain.Characters.Skill;

public static class Skills
{
    public static Skill Acrobatics = new Skill(
        "Acrobatics",
        Attribute.Dexterity,
        true);

    public static Skill Appraise = new Skill(
        "Appraise",
        Attribute.Intelligence,
        true);

    public static Skill Bluff = new Skill(
        "Bluff",
        Attribute.Charisma,
        true);

    public static Skill Climb = new Skill(
        "Climb",
        Attribute.Strength,
        true);

    public static Skill Craft = new Skill(
        "Craft",
        Attribute.Intelligence,
        true);

    public static Skill Diplomacy = new Skill(
        "Diplomacy",
        Attribute.Charisma,
        true);

    public static Skill DisableDevice = new Skill(
        "Disable Device",
        Attribute.Dexterity,
        false);

    public static Skill Disguise = new Skill(
        "Disguise",
        Attribute.Charisma,
        true);

    public static Skill EscapeArtist = new Skill(
        "Escape Artist",
        Attribute.Dexterity,
        true);

    public static Skill Fly = new Skill(
        "Fly",
        Attribute.Dexterity,
        true);

    public static Skill HandleAnimal = new Skill(
        "Handle Animal",
        Attribute.Charisma,
        false);

    public static Skill Heal = new Skill(
        "Heal",
        Attribute.Wisdom,
        true);

    public static Skill Intimidate = new Skill(
        "Intimidate",
        Attribute.Charisma,
        true);

    public static Skill KnowArcana = new Skill(
        "Knowledge (Arcana)",
        Attribute.Intelligence,
        false);

    public static Skill KnowDungeoneering = new Skill(
        "Knowledge (Dungeoneering)",
        Attribute.Intelligence,
        false);

    public static Skill KnowEngineering = new Skill(
        "Knowledge (Engineering)",
        Attribute.Intelligence,
        false);

    public static Skill KnowGeography = new Skill(
        "Knowledge (Geography)",
        Attribute.Intelligence,
        false);

    public static Skill KnowHistory = new Skill(
        "Knowledge (History)",
        Attribute.Intelligence,
        false);

    public static Skill KnowLocal = new Skill(
        "Knowledge (Local)",
        Attribute.Intelligence,
        false);

    public static Skill KnowNature = new Skill(
        "Knowledge (Nature)",
        Attribute.Intelligence,
        false);

    public static Skill KnowNobility = new Skill(
        "Knowledge (Nobility)",
        Attribute.Intelligence,
        false);

    public static Skill KnowPlanes = new Skill(
        "Knowledge (Planes)",
        Attribute.Intelligence,
        false);

    public static Skill KnowReligion = new Skill(
        "Knowledge (Religion)",
        Attribute.Intelligence,
        false);

    public static Skill Linguistics = new Skill(
        "Linguistics",
        Attribute.Intelligence,
        false);

    public static Skill Perception = new Skill(
        "Perception",
        Attribute.Wisdom,
        true);

    public static Skill Profession = new Skill(
        "Profession",
        Attribute.Wisdom,
        false);

    public static Skill Ride = new Skill(
        "Ride",
        Attribute.Dexterity,
        true);

    public static Skill SenseMotive = new Skill(
        "Sense Motive",
        Attribute.Wisdom,
        true);

    public static Skill SleightOfHand = new Skill(
        "Sleight of Hand",
        Attribute.Dexterity,
        false);

    public static Skill Spellcraft = new Skill(
        "Spellcraft",
        Attribute.Intelligence,
        false);

    public static Skill Stealth = new Skill(
        "Stealth",
        Attribute.Dexterity,
        true);

    public static Skill Survival = new Skill(
        "Survival",
        Attribute.Wisdom,
        true);

    public static Skill Swim = new Skill(
        "Swim",
        Attribute.Strength,
        true);

    public static Skill UseMagicDevice = new Skill(
        "Use Magic Device",
        Attribute.Charisma,
        false);

    public static Skill[] skills = [
        Acrobatics,
        Appraise,
        Bluff,
        Climb,
        Craft,
        Diplomacy,
        DisableDevice,
        Disguise,
        EscapeArtist,
        Fly,
        HandleAnimal,
        Heal,
        Intimidate,
        KnowArcana,
        KnowDungeoneering,
        KnowEngineering,
        KnowGeography,
        KnowHistory,
        KnowLocal,
        KnowNature,
        KnowNobility,
        KnowPlanes,
        KnowReligion,
        Linguistics,
        Perception,
        Profession,
        Ride,
        SenseMotive,
        SleightOfHand,
        Spellcraft,
        Stealth,
        Survival,
        Swim,
        UseMagicDevice
    ];
}
