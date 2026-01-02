namespace CGPFE.Domain.Characters.Feats.Properties;

public interface IPrerequisite {
	bool IsSatisfiedBy(Player.Player player);
}