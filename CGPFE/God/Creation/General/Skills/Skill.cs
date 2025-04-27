namespace CGPFE.God.Creation.General.Skills;

public class Skill
{
    public string Name { get; set; }
    public Data.Constants.Attribute Attribute { get; set; }
    public bool ClassSkill { get; set; } = false;
    public bool Untrained { get; set; } = false;
    public int TotalBonus { get; set; }
    public int BaseBonus { get; set; }
    public int RanksBonus { get; set; }
    public int MiscBonus { get; set; }

    public Skill(string name, Data.Constants.Attribute attribute, bool untrained)
    {
        Name = name;
        Attribute = attribute;
        Untrained = untrained;
    }

    private void RecalculateBonus()
    {
        TotalBonus = BaseBonus + RanksBonus + MiscBonus;
    }

    public void SetBaseBonus(int bonus)
    {
        BaseBonus = bonus;
        RecalculateBonus();
    }
    
    public void AddRanks(int ranks)
    {
        RanksBonus += ranks;
        RecalculateBonus();
    }

    public void SetMiscBonus(int bonus)
    {
        MiscBonus = bonus;
        RecalculateBonus();
    }
    
    
}