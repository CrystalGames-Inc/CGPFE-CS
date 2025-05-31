using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Properties;

public abstract class Feat(string name, FeatType type = FeatType.General) {
    public string Name { get; } = name;
    public FeatType Type { get; } = type;
    protected List<IPrerequisite> Prerequisites { get; init; }

    public abstract bool CanAcquire();
    public abstract void Benefits();
}