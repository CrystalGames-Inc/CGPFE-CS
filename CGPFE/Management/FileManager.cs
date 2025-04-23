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
		Directory.CreateDirectory(_worldPath);
		Directory.CreateDirectory(_NPCsPath);
		Directory.CreateDirectory(_playerPath);
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