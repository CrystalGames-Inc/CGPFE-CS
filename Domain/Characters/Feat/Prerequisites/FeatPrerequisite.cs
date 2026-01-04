using CGPFE.Domain.Characters.Player;
using Domain.Characters.Feats;

namespace Domain.Characters.Feat.Prerequisites;

public class FeatPrerequisite(string name) : IPrerequisite
{
    private string Name { get; set; } = name;

    public bool IsSatisfiedBy(Player player)
    {
        return player.HasFeat(Name);
    }
}