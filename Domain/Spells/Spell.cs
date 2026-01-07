using Domain.Spells.Properties;

namespace Domain.Spells;

public class Spell(Info info, Levels classLevels)
{
    public Info Info = info;
    public Levels ClassLevels = classLevels;
}