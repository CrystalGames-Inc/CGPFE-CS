using CGPFE.Data.Models.Spell.Properties;

namespace CGPFE.Data.Models.Spell;

public class Spell(Info info, Levels classLevels) {
	public Info Info = info;
	public Levels ClassLevels = classLevels;
}