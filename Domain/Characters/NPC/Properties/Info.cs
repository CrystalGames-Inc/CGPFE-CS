using Core.Enums;

namespace Domain.Characters.NPC.Properties;

public class Info
{
    public string Name;
    public string? Nickname;
    public NpcType Type;
    public bool Heroic;
    public Race Race;
    public NpcClass Class;
    public Alignment Alignment;
    public Gender Gender;
    public int Level;
}
