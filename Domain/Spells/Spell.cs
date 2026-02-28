using CGPFE.Domain.Spells.Properties;

namespace CGPFE.Domain.Spells;

public abstract class Spell(Info info, Levels classLevels)
{
    public Info Info = info;
    public Levels ClassLevels = classLevels;
}
