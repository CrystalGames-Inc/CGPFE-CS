namespace Domain.Characters.Skill;

public class SkillBonus
{
    public int Size;

    public int AbilityMod;
    public int Ranks;
    public int MiscMod;
    public int RacialBonus;

    public SkillBonus(int abilityMod, int ranks, int miscMod) {
        AbilityMod = abilityMod;
        Ranks = ranks;
        MiscMod = miscMod;
        RacialBonus = 0;
        CalculateBonus();
    }

    private void CalculateBonus() {
        Size = AbilityMod + Ranks + MiscMod + RacialBonus;
    }

    public void SetAbilityMod(int size) {
        AbilityMod = size;
        CalculateBonus();
    }

    public void SetRanks(int size) {
        Ranks = size;
        CalculateBonus();
    }

    public void AddRanks(int ranks) {
        Ranks += ranks;
        CalculateBonus();
    }

    public void SetMiscMod(int size) {
        MiscMod = size;
        CalculateBonus();
    }

}