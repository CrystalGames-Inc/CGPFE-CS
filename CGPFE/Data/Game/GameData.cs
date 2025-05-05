using System.Text.Json;
using CGPFE.Data.Game.StoryModifiers;
using CGPFE.Management;
using CGPFE.World;

namespace CGPFE.Data.Game;

public class GameData(
	string campaignName,
	Fantasty gameFantasty,
	GameSpeed gameSpeed,
	AbilityScoreType abilityScoreType)
{
	public string CampaignName { get; set; } = campaignName;
	public Fantasty GameFantasty { get; set; } = gameFantasty;
	public GameSpeed GameSpeed { get; set; } = gameSpeed;
	public AbilityScoreType AbilityScoreType { get; set; } = abilityScoreType;

	public GameWorld? GameWorld { get; set; }

	
	public string GetJson() => JsonSerializer.Serialize(this);

	public void DisplayGameData()
	{
		Console.WriteLine($"Data for Campaign {CampaignName}:");
		Console.WriteLine($"  Game Fantasty: {GameFantasty}");
		Console.WriteLine($"  Game Speed: {GameSpeed}");
		Console.WriteLine($"  Ability Score Type: {AbilityScoreType}");
	}
}
