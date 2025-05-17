using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat;

public abstract class Feat(string name, FeatType type = FeatType.General) {
    public string Name { get; } = name;
    public FeatType Type { get; } = type;
    protected List<IPrerequisite> Prerequisites { get; init; }

    public abstract bool CanAcquire();
    public abstract void Benefits();
}