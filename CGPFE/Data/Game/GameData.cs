using System.Text.Json;
using CGPFE.Data.Game.StoryModifiers;
using CGPFE.Management;
using CGPFE.World;

namespace CGPFE.Data.Game;

public class GameData(
	string campaignName,
	Fantasty gameFantasty,
	GameSpeed gameSpeed,
	AbilityScoreType abilityScoreType) {

	public string CampaignName = campaignName;

	public Fantasty GameFantasty = gameFantasty;

	public GameSpeed GameSpeed = gameSpeed;

	public AbilityScoreType AbilityScoreType = abilityScoreType;

	public GameWorld? GameWorld;

	public string GetJson() {
		return JsonSerializer.Serialize(this);
	}

	public void DisplayGameData() {
		Console.WriteLine($"Data for Campaign {GameDataManager.Instance.GameData.CampaignName}:");

		Console.WriteLine($"  Game Fantasty: {GameDataManager.Instance.GameData.GameFantasty}");

		Console.WriteLine($"  Game Speed: {GameDataManager.Instance.GameData.GameSpeed}");

		Console.WriteLine($"  Ability Score Type: {GameDataManager.Instance.GameData.AbilityScoreType}");
	}

}