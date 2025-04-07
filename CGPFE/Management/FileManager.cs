using System.Text.Json;
using CGPFE.Data.Game;

namespace CGPFE.Management;

public static class FileManager {
	
	private static readonly JsonSerializerOptions options = new JsonSerializerOptions() {
		WriteIndented = true
	};
	
	private static readonly string EnginePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "CGPFE");
	private static readonly string GameDataFileName = "Settings.json";
	private static string CampaignPath;

	#region Game Data Management
	
	public static void NewGameData() {
		Console.WriteLine("Please choose the campaign's name: ");
		string campaignName = Console.ReadLine();

		Console.WriteLine("Please choose a game fantasty:\nLow - 1\nStandard - 2\nHigh - 3\nEpic - 4");
		int gameFantasty = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException()) - 1;
		
		Console.WriteLine("Please choose the game speed:\nSlow - 1\nMedium - 2\nFast - 3");
		int gameSpeed = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

		Console.WriteLine("Please choose the method of initial point distribution:\nStandard - 1\nClassic - 2\nHeroic - 3\nPurchase - 4");
		int abilityScoreType = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
		
		GameData g = new GameData(campaignName, gameFantasty, gameSpeed, abilityScoreType);
		CampaignPath = Path.Combine(EnginePath, campaignName);
		if(!Directory.Exists(CampaignPath))
			Directory.CreateDirectory(CampaignPath);
		string gameDataPath = Path.Combine(CampaignPath, GameDataFileName);
		CreateJsonFile(g, gameDataPath);
	}

	public static GameData LoadGameData() {
		string[] campaigns = Directory.GetDirectories(EnginePath);

		for (var i = 0; i < campaigns.Length; i++) 
			campaigns[i] = campaigns[i].Split("\\").Last();

		Console.WriteLine("Choose campaign to load: ");
		for(var i = 0; i < campaigns.Length; i++)
			Console.WriteLine($"{i + 1}. {campaigns[i]}");
		
		var loadedCampaign = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

		if (loadedCampaign < 1 || loadedCampaign > campaigns.Length)
			throw new IndexOutOfRangeException();
		
		var filePath = Path.Combine(EnginePath, campaigns[loadedCampaign - 1], GameDataFileName);
		var g = JsonSerializer.Deserialize<GameData>(File.ReadAllText(filePath), options)!;
		
		return g;
	}
	
	#endregion

	#region General Data Management
	
	public static void CreateJsonFile(object obj, string path) {
		while (true) {
			string jsonString = JsonSerializer.Serialize(obj, options);

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
				else {
					Console.WriteLine("Invalid input");
					continue;
				}
			}
			else {
				File.Create(path).Close();
				File.WriteAllText(path, jsonString);

				Console.WriteLine($"File successfully created at {path}");
			}

			break;
		}
	}
	
	public static object ReadJsonFile(string path) {
		object obj;
		try {
			obj = JsonSerializer.Deserialize<dynamic>(File.ReadAllText(path)) ?? throw new InvalidOperationException();

			Console.WriteLine("Successfully read json file");
		}
		catch (Exception e) {
			Console.WriteLine(e);
			throw;
		}

		return obj;
	}
	
	#endregion
}