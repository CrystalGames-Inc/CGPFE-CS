namespace CGPFE.God.Creation.General.Feats.Prerequisites;

public class LevelPrerequisite(int minLevel) : IPrerequisite {
	
	public int MinLevel { get; init; } = minLevel;

	public bool IsSatisfiedBy(Player.Player player) {
		return player.PlayerInfo.Level >= MinLevel;
	}
}