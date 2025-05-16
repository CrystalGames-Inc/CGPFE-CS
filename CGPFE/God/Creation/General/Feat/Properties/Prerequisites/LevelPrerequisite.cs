namespace CGPFE.God.Creation.General.Feat.Properties.Prerequisites;

public class LevelPrerequisite(int minLevel) : IPrerequisite {
	
	public int MinLevel { get; init; } = minLevel;

	public bool IsSatisfiedBy(Player.Player player) {
		return player.PlayerInfo.Level >= MinLevel;
	}
}