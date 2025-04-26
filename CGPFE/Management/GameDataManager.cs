using CGPFE.Data.Game;
using CGPFE.Data.Game.StoryModifiers;

namespace CGPFE.Management;

public class GameDataManager {

	public GameData GameData = new GameData();
	
	private static GameDataManager _instance = null;
	private static readonly object Padlock = new object();

	public static GameDataManager Instance {
		get {
			lock (Padlock) {
				_instance ??= new GameDataManager();
			}
			return _instance;
		}
	}
	
	
	public void DisplayGameData() {
		Console.WriteLine($"Campaign Name: {GameData.CampaignName}");
		switch (GameData.GameFantasty) {
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

		switch (GameData.GameSpeed) {
			case 0:
				Console.WriteLine($"Game Speed: {GameSpeed.Slow}");
				break;
			case 1:
				Console.WriteLine($"Game Speed: {GameSpeed.Medium}");
				break;
			case 2:
				Console.WriteLine($"Game Speed: {GameSpeed.Fast}");
				break;
		}

		switch (GameData.AbilityScoreType) {
			case 0:
				Console.WriteLine($"Initial Point Distribution: {AbilityScoreType.Standard}");
				break;
			case 1:
				Console.WriteLine($"Initial Point Distribution: {AbilityScoreType.Classic}");
				break;
			case 2:
				Console.WriteLine($"Initial Point Distribution: {AbilityScoreType.Heroic}");
				break;
			case 3:
				Console.WriteLine($"Initial Point Distribution: {AbilityScoreType.Purchase}");
				break;
		}
	}

	public GameData RegisterGameData() {
		Console.WriteLine("Please choose the campaign's name: ");
		GameData.CampaignName = Console.ReadLine();

		Console.WriteLine("Please choose a game fantasty:\nLow - 1\nStandard - 2\nHigh - 3\nEpic - 4");
		GameData.GameFantasty = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException()) - 1;
		
		Console.WriteLine("Please choose the game speed:\nSlow - 1\nMedium - 2\nFast - 3");
		GameData.GameSpeed = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

		Console.WriteLine("Please choose the method of initial point distribution:\nStandard - 1\nClassic - 2\nHeroic - 3\nPurchase - 4");
		GameData.AbilityScoreType = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
		
		FileManager.UpdatePaths(GameData.CampaignName);

		return new GameData();
	}

	public void AskNewCharacter() {
		Console.WriteLine("Would you also like to create a new player? [Y/N] (Default: N)");
		var newPlayer = Console.ReadLine();
		switch (newPlayer.ToUpper()) {
			case "Y":
				PlayerDataManager.Instance.RegisterPlayer();
			break;
			default:
				Console.WriteLine();
			break;
		}
	}
}