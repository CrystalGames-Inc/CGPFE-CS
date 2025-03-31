using CGPFE.Data.Game.StoryModifiers;
using CGPFE.World;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CGPFE.Data.Game;

public class GameData {

	public string CampaignName;
	
	[JsonConverter(typeof(StringEnumConverter))]
	public Fantasty GameFantasty;
	
	[JsonConverter(typeof(StringEnumConverter))]
	public AbilityScoreType AbilityScoreType;
	
	[JsonConverter(typeof(StringEnumConverter))]
	public GameSpeed GameSpeed;
	
	public GameWorld? GameWorld;
	
	private readonly string _gameDataPath = Path.Combine(Environment.SpecialFolder.ApplicationData.ToString(), "CGPFE");
	private readonly string _filePath = Path.Combine(Environment.SpecialFolder.ApplicationData.ToString(), "CGPFE", "GameData.json");
	
	public GameData(string campaignName,Fantasty gameFantasty,AbilityScoreType abilityScoreType,GameSpeed gameSpeed, GameWorld? gameWorld) {
		CampaignName = campaignName;
		GameFantasty = gameFantasty;
		AbilityScoreType = abilityScoreType;
		GameSpeed = gameSpeed;
		
		CheckGameDataFile();
	}

	private void RegisterGameData() {
		GameData g = new GameData("Placeholder", Fantasty.Standard, AbilityScoreType.Standard, GameSpeed.Medium, null);
		string json = JsonConvert.SerializeObject(g);
		JsonSerializer serializer = new JsonSerializer();
		try {
			using (StreamWriter sw = new StreamWriter(_filePath))
				using (JsonWriter writer = new JsonTextWriter(sw)) {
					serializer.Serialize(writer, GameWorld);
				}
		}
		catch (Exception e) {
			Console.WriteLine(e);
		}
	}

	private void CheckGameDataFile() {
		if(!Directory.Exists(_gameDataPath))
			Directory.CreateDirectory(_gameDataPath);
		else
			Console.WriteLine($"Directory already exists at {_gameDataPath}");
		
		if (!Directory.Exists(_filePath)) {
			File.Create(_filePath).Close();
		}
		else {
			Console.WriteLine($"File already exists at {_filePath}");
			Thread.Sleep(3000);
			Console.WriteLine("Overwriting file...");
		}
	}
}