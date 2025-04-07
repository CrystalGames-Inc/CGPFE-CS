using System.Text.Json;
using CGPFE.Data.Game.StoryModifiers;
using CGPFE.World;

namespace CGPFE.Data.Game;

public class GameData(string campaignName, int gameFantasty, int gameSpeed, int abilityScoreType) {

	public string CampaignName { get; set; } = campaignName;

	public int GameFantasty { get; set; } = gameFantasty;

	public int GameSpeed { get; set; } = gameSpeed;

	public int AbilityScoreType { get; set; } = abilityScoreType;

	public GameWorld? GameWorld;

	public void DisplayGameData() {
		Console.WriteLine($"Campaign Name: {CampaignName}");
		switch (GameFantasty) {
			case 0:
				Console.WriteLine($"Game Fantasty: {Fantasty.Low}");
				break;
			case 1:
				Console.WriteLine($"Game Fantasty: {Fantasty.Standard}");
				break;
			case 2:
				Console.WriteLine($"Game Fantasty: {Fantasty.High}");
				break;
			case 3:
				Console.WriteLine($"Game Fantasty: {Fantasty.Epic}");
				break;
		}

		switch (GameSpeed) {
			case 0:
				Console.WriteLine($"Game Speed: {StoryModifiers.GameSpeed.Slow}");
				break;
			case 1:
				Console.WriteLine($"Game Speed: {StoryModifiers.GameSpeed.Medium}");
				break;
			case 2:
				Console.WriteLine($"Game Speed: {StoryModifiers.GameSpeed.Fast}");
				break;
		}

		switch (AbilityScoreType) {
			case 0:
				Console.WriteLine($"Initial Point Distribution: {StoryModifiers.AbilityScoreType.Standard}");
				break;
			case 1:
				Console.WriteLine($"Initial Point Distribution: {StoryModifiers.AbilityScoreType.Classic}");
				break;
			case 2:
				Console.WriteLine($"Initial Point Distribution: {StoryModifiers.AbilityScoreType.Heroic}");
				break;
			case 3:
				Console.WriteLine($"Initial Point Distribution: {StoryModifiers.AbilityScoreType.Purchase}");
				break;
		}
	}
}