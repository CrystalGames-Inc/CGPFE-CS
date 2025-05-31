using CGPFE.Data.Game;
using CGPFE.Data.Game.StoryModifiers;

namespace CGPFE.Management;

public class GameDataManager {

	public GameData GameData = new GameData("Placeholder", Fantasty.Standard, GameSpeed.Medium, AbilityScoreType.Standard);
	
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

	public GameData RegisterGameData() {
		Console.WriteLine("Please choose the campaign's name: ");
		GameData.CampaignName = Console.ReadLine();

		Console.WriteLine("Please choose a game fantasty (Default - Standard):\nLow - 1\nStandard - 2\nHigh - 3\nEpic - 4");
		var fantasty = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException()) - 1;
		GameData.GameFantasty = fantasty switch {
			0 => Fantasty.Low,
			1 => Fantasty.Standard,
			2 => Fantasty.High,
			3 => Fantasty.Epic,
			_ => Fantasty.Standard
		};
		
		Console.WriteLine("Please choose the game speed (Default - Medium):\nSlow - 1\nMedium - 2\nFast - 3");
		var gameSpeed = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
		GameData.GameSpeed = gameSpeed switch {
			1 => GameSpeed.Slow,
			2 => GameSpeed.Medium,
			3 => GameSpeed.Fast,
			_ => GameSpeed.Medium
		};

		Console.WriteLine("Please choose the method of initial point distribution ( Default - Standard):\nStandard - 1\nClassic - 2\nHeroic - 3\nPurchase - 4");
		var scoreType = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
		GameData.AbilityScoreType = scoreType switch {
			1 => AbilityScoreType.Standard,
			2 => AbilityScoreType.Classic,
			3 => AbilityScoreType.Heroic,
			4 => AbilityScoreType.Purchase,
			_ => AbilityScoreType.Standard
		};
		
		FileManager.UpdatePaths(GameData.CampaignName);

		return GameData;
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

	public void AskNewWorld() {
		Console.WriteLine("Would you like to create the game world [Y/N] (Default: N)");
		var newWorld = Console.ReadLine();
		switch (newWorld.ToUpper()) {
			case "Y":
				WorldManager.Instance.RegisterWorld();
				break;
			default:
				Console.WriteLine();
				break;
		}
	}
}