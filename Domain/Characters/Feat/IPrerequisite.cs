using CGPFE.Domain.Characters.Player;

namespace Domain.Characters.Feats;

public interface IPrerequisite
{
    bool IsSatisfiedBy(Player player);
}