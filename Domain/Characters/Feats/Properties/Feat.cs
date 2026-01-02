using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Player;

namespace CGPFE.Domain.Characters.Feats.Properties;

public abstract class Feat {
    public string Name { get; }
    public FeatType Type { get; }

    protected Feat(string name, FeatType type)
    {
        Name = name;
        Type = type;
    }

    public abstract bool CanAcquire(Player.Player player);
    public abstract void Benefits();
}