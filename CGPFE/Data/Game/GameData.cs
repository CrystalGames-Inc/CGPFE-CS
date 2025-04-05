using System.Text.Json;
using CGPFE.Data.Game.StoryModifiers;
using CGPFE.World;

namespace CGPFE.Data.Game;

public class GameData {

	public string CampaignName { get; set; }

	public int GameFantasty { get; set; }
	
	public int GameSpeed { get; set; }
	
	public int AbilityScoreType { get; set; }
	
	public GameWorld? GameWorld;
	
	private readonly string _gameDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "CGPFE");
	private readonly string _filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "CGPFE", "GameData.json");
	private string _jsonString = string.Empty;
	
	public GameData() {
		Console.WriteLine("Please choose a name for the campaign: ");
		CampaignName = Console.ReadLine() ?? throw new InvalidOperationException();

		Console.WriteLine("Please choose a game fantasty:\nLow - 1\nStandard - 2\nHigh - 3\nEpic - 4");
		GameFantasty = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException()) - 1;

		Console.WriteLine("Please choose the game speed:\nSlow - 1\nMedium - 2\nFast - 3");
		GameSpeed = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

		Console.WriteLine("Please choose the method of initial point distribution:\nStandard - 1\nClassic - 2\nHeroic - 3\nPurchase - 4");
		AbilityScoreType = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

		if (!Directory.Exists(_gameDataPath)) 
			Directory.CreateDirectory(_gameDataPath);

		if(!File.Exists(_filePath))
			File.Create(_filePath).Close();
		
		var o = new JsonSerializerOptions() {
			WriteIndented = true
		};
		
		GameData g = new GameData(CampaignName, GameFantasty, GameSpeed, AbilityScoreType);
		
		_jsonString = JsonSerializer.Serialize<GameData>(g, o);
		Console.WriteLine(_jsonString);

		Console.WriteLine("Writing data to file...");
		Thread.Sleep(2000);
		
		try {
			File.WriteAllText(_filePath, _jsonString);
		}
		catch (Exception e) {
			Console.WriteLine("Could not write data");
			Console.WriteLine(e);
			throw;
		}

		Console.WriteLine($"Successfully written game data to {_filePath}");
	}

	public GameData(string campaignName, int gameFantasty, int gameSpeed, int abilityScoreType) {
		CampaignName = campaignName;
		GameFantasty = gameFantasty;
		GameSpeed = gameSpeed;
		AbilityScoreType = abilityScoreType;
	}
}