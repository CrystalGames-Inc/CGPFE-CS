namespace Domain.Characters.Feats;

public interface IPrerequisite {
	bool IsSatisfiedBy(Player.Player player);
}