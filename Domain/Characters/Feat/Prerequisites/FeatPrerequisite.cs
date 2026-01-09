using CGPFE.Domain.Characters.Feat;

namespace CGPFE.Domain.Characters.Feat.Prerequisites;

public class FeatPrerequisite(string name) : IPrerequisite
{
    private string Name { get; set; } = name;

    public bool IsSatisfiedBy(Player.Player player) {
        return player.HasFeat(Name);
    }
}
