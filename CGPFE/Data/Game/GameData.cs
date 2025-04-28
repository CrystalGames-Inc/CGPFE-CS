using System.Text.Json;
using CGPFE.Data.Game.StoryModifiers;
using CGPFE.Management;
using CGPFE.World;

namespace CGPFE.Data.Game;

public class GameData {

	public string CampaignName { get; set; } = "Placeholder";

	public Fantasty GameFantasty { get; set; } = Fantasty.Standard;

	public GameSpeed GameSpeed { get; set; } = GameSpeed.Medium;

	public AbilityScoreType AbilityScoreType { get; set; } = AbilityScoreType.Standard;

	public GameWorld? GameWorld;

	public GameData() {
		
	}

	public GameData(string campaignName, Fantasty gameFantasty, GameSpeed gameSpeed, AbilityScoreType abilityScoreType) {
		CampaignName = campaignName;
		GameFantasty = gameFantasty;
		GameSpeed = gameSpeed;
		AbilityScoreType = abilityScoreType;
	}

	public void DisplayGameData() {
		Console.WriteLine($"Data for Campaign {CampaignName}:");
		switch (GameFantasty) {
			case Fantasty.Low:
				Console.WriteLine("  Game Fantasty: Low");
			break;
			case Fantasty.Standard:
				Console.WriteLine("  Game Fantasty: Standard");
			break;
			case Fantasty.High:
				Console.WriteLine("  Game Fantasty: High");
			break;
			case Fantasty.Epic:
				Console.WriteLine("  Game Fantasty: Epic");
			break;
		}

		switch (GameSpeed) {
			case GameSpeed.Slow:
				Console.WriteLine("  Game Speed: Slow");
			break;
			case GameSpeed.Medium:
				Console.WriteLine("  Game Speed: Medium");
			break;
			case GameSpeed.Fast:
				Console.WriteLine("  Game Speed: Fast");
			break;
		}

		switch (AbilityScoreType) {
			case AbilityScoreType.Standard:
				Console.WriteLine("  Ability Score Type: Standard");
			break;
			case AbilityScoreType.Classic:
				Console.WriteLine("  Ability Score Type: Classic");
			break;
			case AbilityScoreType.Heroic:
				Console.WriteLine("  Ability Score Type: Heroic");
			break;
			case AbilityScoreType.Purchase:
				Console.WriteLine("  Ability Score Type: Purchase");
			break;
		}
	}

}