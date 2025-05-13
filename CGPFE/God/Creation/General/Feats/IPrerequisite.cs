namespace CGPFE.God.Creation.General.Feats;

public interface IPrerequisite {
	bool IsSatisfiedBy(Player.Player player);
}