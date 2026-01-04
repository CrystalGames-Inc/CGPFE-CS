using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Player;
using Domain.Characters.Feats;

namespace Domain.Characters.Feat;

public abstract class Feat
{
    public string Name { get; }
    public FeatType Type { get; }
    public List<IPrerequisite> Prerequisites { get; set; } = new();

    protected Feat(string name, FeatType type)
    {
        Name = name;
        Type = type;
    }

    public abstract bool CanAcquire(Player player);
    public abstract void ApplyBenefits(ref Player player);
}