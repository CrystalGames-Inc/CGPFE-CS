using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.NPC.Properties;

public class NPCInfo
{
    public float? CR;
    public string Name;
    public string? Nickname;
    public NpcType Type;
    public bool Heroic;
    public Race Race;
    public NpcClass Class;
    public Alignment Alignment;
    public Gender Gender;
    public int? Level;
    public int? XP;
    public Dictionary<string, int>? SkillBonuses;
    public string[]? Feats;
}
