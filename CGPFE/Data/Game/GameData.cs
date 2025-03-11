using CGPFE.Data.Game.StoryModifiers;
using CGPFE.World;

namespace CGPFE.Data.Game;

public class GameData(
	string campaignName,
	Fantasty gameFantasty,
	AbilityScoreType abilityScoreType,
	GameSpeed gameSpeed,
	GameWorld gameWorld) {

	public string CampaignName = campaignName;
	
	public Fantasty GameFantasty = gameFantasty;
	public AbilityScoreType AbilityScoreType = abilityScoreType;
	public GameSpeed GameSpeed = gameSpeed;
	public GameWorld GameWorld = gameWorld;
}