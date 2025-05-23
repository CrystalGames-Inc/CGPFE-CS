namespace CGPFE.God.Creation.General.Feat.Properties.Prerequisites;

public class FeatPrerequisite(string name) : IPrerequisite {
	private string Name { get; set; } = name;

	public bool IsSatisfiedBy(Player.Player player) {
		return player.HasFeat(Name);
	}
}