using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.NPC.Properties;

public class Info(string name, string? nickname, Race race, NpcClass @class, Alignment alignment, Gender gender, int level)
{
    public readonly string Name = name;
    public readonly string? Nickname = nickname;
    public readonly Race Race = race;
    public readonly NpcClass Class = @class;
    public Alignment Alignment = alignment;
    public Gender Gender = gender;
    public int Level = level;

    public Info(string name, Race race, NpcClass @class, Alignment alignment, Gender gender, int level) : this(name, null, race, @class, alignment, gender, level) {
    }
}