using Domain.Characters.Feat;
using Core.Enums;

namespace Domain.Characters.Feat;

public abstract class Feat
{
    public string Name { get; }
    public FeatType Type { get; }
    public List<IPrerequisite> Prerequisites { get; set; } = new();

    protected Feat(string name, FeatType type = FeatType.General) {
        Name = name;
        Type = type;
    }

    public abstract bool CanAcquire(Player.Player player);
    public abstract void ApplyBenefits(ref Player.Player player);
}
