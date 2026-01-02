using Attribute = CGPFE.Core.Enums.Attribute;

namespace CGPFE.Domain.Characters.Skills.Skills;

public class Skill
{
    public string Name { get; set; }
    public Attribute Attribute { get; set; }
    public bool ClassSkill { get; set; } = false;
    public bool Untrained { get; set; } = false;

    public SkillBonus Bonus { get; set; } = new SkillBonus(0, 0, 0);
    
    public Skill(string name, Attribute attribute, bool untrained)
    {
        Name = name;
        Attribute = attribute;
        Untrained = untrained;
    }

    public bool SkillCheck(int dc) {
        
        
        return false;
    }

    public int GetSkillCheckBonus() {
        int bonus = 0;

        if (Untrained) {
            bonus += Bonus.AbilityMod;
        }
        
        
        return bonus;
    }
}