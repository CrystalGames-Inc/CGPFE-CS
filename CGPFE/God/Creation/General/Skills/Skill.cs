namespace CGPFE.God.Creation.General.Skills;

public class Skill
{
    public string Name { get; set; }
    public Data.Constants.Attribute Attribute { get; set; }
    public bool ClassSkill { get; set; } = false;
    public bool Untrained { get; set; } = false;

    public SkillBonus Bonus { get; set; } = new SkillBonus(0, 0, 0);
    
    public Skill(string name, Data.Constants.Attribute attribute, bool untrained)
    {
        Name = name;
        Attribute = attribute;
        Untrained = untrained;
    }
}