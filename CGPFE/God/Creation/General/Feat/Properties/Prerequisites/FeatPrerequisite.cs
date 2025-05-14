namespace CGPFE.God.Creation.General.Feats.Prerequisites;

public class FeatPrerequisite : IPrerequisite {
	public string Name { get; set; }

	public bool IsSatisfiedBy(Player.Player player) {
		return player.HasFeat(Name);
	}
}