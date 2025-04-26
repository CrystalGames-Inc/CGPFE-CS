using System.Text.Json;
using CGPFE.Data.Game.StoryModifiers;
using CGPFE.Management;
using CGPFE.World;

namespace CGPFE.Data.Game;

public class GameData {

	public string CampaignName { get; set; }

	public int GameFantasty { get; set; }

	public int GameSpeed { get; set; }

	public int AbilityScoreType { get; set; }

	public GameWorld? GameWorld;

	public GameData() {
		
	}

	public GameData(string campaignName, int gameFantasty, int gameSpeed, int abilityScoreType) {
		CampaignName = campaignName;
		GameFantasty = gameFantasty;
		GameSpeed = gameSpeed;
		AbilityScoreType = abilityScoreType;
	}


}