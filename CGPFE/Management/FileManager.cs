using System.Text.Json;
using CGPFE.Data.Game;

namespace CGPFE.Management;

public static class FileManager {
	
	private static readonly JsonSerializerOptions Options = new JsonSerializerOptions() {
		WriteIndented = true
	};
	
	private static readonly string SavesPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "CGPFE");
	private static string _gameDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "CGPFE");
	private static string _resourcesPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "CGPFE");
	private static string _worldPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "CGPFE");
	private static string _NPCsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "CGPFE");
	private static string _playerPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "CGPFE");
	private const string GameDataFileName = "Settings.json";
	private static string _campaignPath = string.Empty;

	#region Campaign Data Management
	
	public static GameData NewGameData() {
		var g = GameData.RegisterGameData();
		
		UpdatePaths(g.CampaignName);
		CreateDirectories();
		
		if(!Directory.Exists(_campaignPath))
			Directory.CreateDirectory(_campaignPath);
		var gameDataPath = Path.Combine(_gameDataPath, GameDataFileName);
		
		CreateJsonFile(g, gameDataPath);
		
		return g;
	}

	private static void UpdatePaths(string campaignName) {
		_campaignPath = Path.Combine(SavesPath, campaignName);
		_gameDataPath = Path.Combine(_campaignPath, "Game");
		_resourcesPath = Path.Combine(_campaignPath, "Resources");
		_worldPath = Path.Combine(_campaignPath, "World");
		_NPCsPath = Path.Combine(_campaignPath, "NPCs");
		_playerPath = Path.Combine(_campaignPath, "Player");
	}
	
	private static void CreateDirectories() {
		Directory.CreateDirectory(_gameDataPath);
		Directory.CreateDirectory(_resourcesPath);
		Directory.CreateDirectory(_worldPath);
		Directory.CreateDirectory(_NPCsPath);
		Directory.CreateDirectory(_playerPath);
	}

	private static void CreateResources() {
		File.Create(Path.Combine(_resourcesPath, "AlchemistCT.json"));
		File.Create(Path.Combine(_resourcesPath, "BarbarianCT.json"));
		File.Create(Path.Combine(_resourcesPath, "BardCT.json"));
		File.Create(Path.Combine(_resourcesPath, "CavalierCT.json"));
		File.Create(Path.Combine(_resourcesPath, "ClericCT.json"));
		File.Create(Path.Combine(_resourcesPath, "DruidCT.json"));
		File.Create(Path.Combine(_resourcesPath, "FighterCT.json"));
		File.Create(Path.Combine(_resourcesPath, "InquisitorCT.json"));
		File.Create(Path.Combine(_resourcesPath, "MonkCT.json"));
		File.Create(Path.Combine(_resourcesPath, "OracleCT.json"));
		File.Create(Path.Combine(_resourcesPath, "PaladinCT.json"));
		File.Create(Path.Combine(_resourcesPath, "RangerCT.json"));
		File.Create(Path.Combine(_resourcesPath, "RogueCT.json"));
		File.Create(Path.Combine(_resourcesPath, "SorcererCT.json"));
		File.Create(Path.Combine(_resourcesPath, "SummonerCT.json"));
		File.Create(Path.Combine(_resourcesPath, "WitchCT.json"));
		File.Create(Path.Combine(_resourcesPath, "WizardCT.json"));
		
		File.WriteAllText(Path.Combine(_resourcesPath, "AlchemistCT.json"), "[{'BAB':0,'Fort':0,'Ref':0,'Will':2},{'BAB':1,'Fort':0,'Ref':0,'Will':3},{'BAB':1,'Fort':1,'Ref':1,'Will':3},{'BAB':2,'Fort':1,'Ref':1,'Will':4},{'BAB':2,'Fort':1,'Ref':1,'Will':4},{'BAB':3,'Fort':2,'Ref':2,'Will':5},{'BAB':3,'Fort':2,'Ref':2,'Will':5},{'BAB':4,'Fort':2,'Ref':2,'Will':6},{'BAB':4,'Fort':3,'Ref':3,'Will':6},{'BAB':5,'Fort':3,'Ref':3,'Will':7},{'BAB':5,'Fort':3,'Ref':3,'Will':7},{'BAB':6,'Fort':4,'Ref':4,'Will':8},{'BAB':6,'Fort':4,'Ref':4,'Will':8},{'BAB':7,'Fort':4,'Ref':4,'Will':9},{'BAB':7,'Fort':5,'Ref':5,'Will':9},{'BAB':8,'Fort':5,'Ref':5,'Will':10},{'BAB':8,'Fort':5,'Ref':5,'Will':10},{'BAB':9,'Fort':6,'Ref':6,'Will':11},{'BAB':9,'Fort':6,'Ref':6,'Will':11},{'BAB':10,'Fort':6,'Ref':6,'Will':12}]");
		File.WriteAllText(Path.Combine(_resourcesPath, "BarbarianCT.json"), "[{'BAB':1,'Fort':2,'Ref':0,'Will':0},{'BAB':2,'Fort':3,'Ref':0,'Will':0},{'BAB':3,'Fort':3,'Ref':1,'Will':1},{'BAB':4,'Fort':4,'Ref':1,'Will':1},{'BAB':5,'Fort':4,'Ref':1,'Will':1},{'BAB':6,'Fort':5,'Ref':2,'Will':2},{'BAB':7,'Fort':5,'Ref':2,'Will':2},{'BAB':8,'Fort':6,'Ref':2,'Will':2},{'BAB':9,'Fort':6,'Ref':3,'Will':3},{'BAB':10,'Fort':7,'Ref':3,'Will':3},{'BAB':11,'Fort':7,'Ref':3,'Will':3},{'BAB':12,'Fort':8,'Ref':4,'Will':4},{'BAB':13,'Fort':8,'Ref':4,'Will':4},{'BAB':14,'Fort':9,'Ref':4,'Will':4},{'BAB':15,'Fort':9,'Ref':5,'Will':5},{'BAB':16,'Fort':10,'Ref':5,'Will':5},{'BAB':17,'Fort':10,'Ref':5,'Will':5},{'BAB':18,'Fort':11,'Ref':6,'Will':6},{'BAB':19,'Fort':11,'Ref':6,'Will':6},{'BAB':20,'Fort':12,'Ref':6,'Will':6}]");
		
		
	}

	public static GameData LoadGameData() {
		var campaigns = Directory.GetDirectories(SavesPath);

		for (var i = 0; i < campaigns.Length; i++) 
			campaigns[i] = campaigns[i].Split("\\").Last();

		Console.WriteLine("Choose campaign to load: ");
		for(var i = 0; i < campaigns.Length; i++)
			Console.WriteLine($"{i + 1}. {campaigns[i]}");
		
		var loadedCampaign = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

		if (loadedCampaign < 1 || loadedCampaign > campaigns.Length)
			throw new IndexOutOfRangeException();
		
		var filePath = Path.Combine(SavesPath, campaigns[loadedCampaign - 1], GameDataFileName);
		var g = JsonSerializer.Deserialize<GameData>(File.ReadAllText(filePath), Options)!;
		
		return g;
	}
	
	#endregion

	#region General Data Management
	
	public static void CreateJsonFile(object obj, string path) {
			var jsonString = JsonSerializer.Serialize(obj, Options);

			if (File.Exists(path)) {
				Console.WriteLine($"File already exists at {path}\nOverwrite? [Y/N]");
				var ans = Console.ReadLine() ?? throw new InvalidOperationException();
				if (string.Equals(ans, "N", StringComparison.OrdinalIgnoreCase))
					return;
				if (string.Equals(ans, "Y", StringComparison.OrdinalIgnoreCase)) {
					try {
						File.Create(path).Close();
						File.WriteAllText(path, jsonString);

						Console.WriteLine($"File successfully created at {path}");
					}
					catch (Exception e) {
						Console.WriteLine(e);
					}
				}
			} else {
				File.Create(path).Close();
				File.WriteAllText(path, jsonString);

				Console.WriteLine($"File successfully created at {path}");
			}
	}
	
	#endregion
}