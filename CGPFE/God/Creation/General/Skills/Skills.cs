using Attribute = CGPFE.Data.Constants.Attribute;

namespace CGPFE.God.Creation.General.Skills;

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
}