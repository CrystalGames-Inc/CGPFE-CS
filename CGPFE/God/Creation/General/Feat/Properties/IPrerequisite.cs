namespace CGPFE.God.Creation.General.Feat.Properties;

public interface IPrerequisite {
	bool IsSatisfiedBy(Player.Player player);
}