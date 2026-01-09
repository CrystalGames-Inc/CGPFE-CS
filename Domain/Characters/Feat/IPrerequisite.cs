namespace Domain.Characters.Feat;

public interface IPrerequisite
{
    bool IsSatisfiedBy(Player.Player player);
}
