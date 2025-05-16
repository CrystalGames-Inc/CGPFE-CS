using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties;

namespace CGPFE.God.Creation.General.Feat;

public abstract class Feat(string name, FeatType type) {
    public string Name { get; } = name;
    public FeatType Type { get; } = type;
    public List<IPrerequisite> Prerequisites { get; init; }

    public Feat(string name) : this(name, FeatType.General) {
    }

    public abstract bool CanAcquire();
    public abstract void Benefits();
}