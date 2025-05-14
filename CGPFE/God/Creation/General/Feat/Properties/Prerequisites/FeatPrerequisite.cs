namespace CGPFE.God.Creation.General.Feats.Prerequisites;

public class FeatPrerequisite(string name) : IPrerequisite {
	public string Name { get; set; } = name;

	public bool IsSatisfiedBy(Player.Player player) {
		return player.HasFeat(Name);
	}
}