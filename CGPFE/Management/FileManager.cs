using System.Text.Json;
using CGPFE.Data.Constants;
using CGPFE.Data.Game;
using CGPFE.God.Creation.General;
using CGPFE.God.Creation.Player;
using CGPFE.God.Creation.Player.Properties;
using CGPFE.God.Creation.Player.Properties.Inventory;

namespace CGPFE.Management;

public static class FileManager {
	
	public static bool DebugMode = false;
	
	private static readonly JsonSerializerOptions? Options = new() {
		WriteIndented = true,
		PropertyNameCaseInsensitive = true
	};
	
	#region Paths
	
	private const string EngineName = "CGPFE";
	
	private static readonly string SavesPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), EngineName);
	private static string _gameDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), EngineName);
	private static string _resourcesPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), EngineName);
	private static string _worldPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), EngineName);
	private static string _npCsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), EngineName);
	private static string _playerPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), EngineName);
	private static string _inventoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), EngineName);
	private static string _campaignPath = string.Empty;
	
	#endregion
	
	#region File Names
	
	private const string GameDataFileName = "Settings.json";
	private const string PlayerInfoFileName = "PlayerInfo.json";
	private const string AttributesFileName = "PlayerAttributes.json";
	private const string AttributeModsFileName = "PlayerAttributeMods.json";
	private const string CombatInfoFileName = "CombatInfo.json";
	private const string WalletFileName = "PlayerWallet.json";
	private const string FeatsFileName = "PlayerFeats.json";
	
	/*The inventory items file names*/
	private const string ItemsFileName = "PlayerItems.json";
	private const string WeaponsFileName = "PlayerWeapons.json";
	private const string ArmorsFileName = "PlayerArmors.json";
	private const string ShieldsFileName = "PlayerShields.json";
	
	#endregion

	#region Campaign File Management
	
	public static GameData NewGameData() {
		var g = GameDataManager.Instance.RegisterGameData();
		CreateGameDirectories();
		
		GameDataManager.Instance.AskNewCharacter();
		
		if(!Directory.Exists(_campaignPath))
			Directory.CreateDirectory(_campaignPath);
		var gameDataPath = Path.Combine(_gameDataPath, GameDataFileName);
		
		SerializeToFile(gameDataPath, g);
		GameDataManager.Instance.GameData = g;
		
		return g;
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
		
		var filePath = Path.Combine(SavesPath, campaigns[loadedCampaign - 1], "Game", GameDataFileName);
		UpdatePaths(campaigns[loadedCampaign - 1]);
		var jsonString = File.ReadAllText(filePath);
		GameData g = JsonSerializer.Deserialize<GameData>(jsonString, Options);

		Console.WriteLine($"Loaded json file from path {filePath}: {File.ReadAllText(filePath)}");

		if (!File.Exists(_playerPath + "\\PlayerInfo.json")) return g;
		Console.WriteLine("Player data detected, loading player");
		PlayerDataManager.Instance.Player = LoadPlayerData();

		return g;
	}

	public static void UpdatePaths(string campaignName) {
		_campaignPath = Path.Combine(SavesPath, campaignName);
		_gameDataPath = Path.Combine(_campaignPath, "Game");
		_resourcesPath = Path.Combine(_campaignPath, "Resources");
		_worldPath = Path.Combine(_campaignPath, "World");
		_npCsPath = Path.Combine(_campaignPath, "NPCs");
		_playerPath = Path.Combine(_campaignPath, "Player");
		_inventoryPath = Path.Combine(_playerPath, "Inventory");
	}
	
	private static void CreateGameDirectories() {
		Directory.CreateDirectory(_gameDataPath);
		Directory.CreateDirectory(_resourcesPath);
		Directory.CreateDirectory(_worldPath);
		Directory.CreateDirectory(_npCsPath);
		Directory.CreateDirectory(_playerPath);
		Directory.CreateDirectory(_inventoryPath);
	}

	#endregion
	
	#region Player File Management
	
	public static void WritePlayerData() {
		var player = PlayerDataManager.Instance.Player;
		
		WritePlayerProperty(player.PlayerInfo, PlayerInfoFileName);
		WritePlayerProperty(player.Attributes, AttributesFileName);
		WritePlayerProperty(player.AttributeModifiers, AttributeModsFileName);
		WritePlayerProperty(player.Wallet, WalletFileName);
		WritePlayerProperty(player.CombatInfo, CombatInfoFileName);
		WritePlayerProperty(player.Feats, FeatsFileName);
		WritePlayerProperty(player.Inventory.Items, _inventoryPath, ItemsFileName);
		WritePlayerProperty(player.Inventory.Weapons, _inventoryPath, WeaponsFileName);
		WritePlayerProperty(player.Inventory.Armors, _inventoryPath, ArmorsFileName);
		WritePlayerProperty(player.Inventory.Shields, _inventoryPath, ShieldsFileName);
		
		if(DebugMode)
			Console.WriteLine($"Loaded all files from {_playerPath}");
	}

	private static Player LoadPlayerData() {
		if (!Directory.EnumerateFiles(_playerPath).Any() && DebugMode) {
			Console.WriteLine("No player found to load, returning null");
			return null;
		}

		PlayerDataManager.Instance.Player.PlayerInfo = LoadPlayerProperty<PlayerInfo>(PlayerInfoFileName);
		PlayerDataManager.Instance.Player.Attributes = LoadPlayerProperty<Attributes>(AttributesFileName);
		PlayerDataManager.Instance.Player.AttributeModifiers = LoadPlayerProperty<Attributes>(AttributeModsFileName);
		PlayerDataManager.Instance.Player.Wallet =  LoadPlayerProperty<Wallet>(WalletFileName);
		PlayerDataManager.Instance.Player.CombatInfo = LoadPlayerProperty<CombatInfo>(CombatInfoFileName);
		PlayerDataManager.Instance.Player.Inventory = LoadPlayerInventory();

		return new Player {
			PlayerInfo = PlayerDataManager.Instance.Player.PlayerInfo,
			Attributes = PlayerDataManager.Instance.Player.Attributes,
			AttributeModifiers = PlayerDataManager.Instance.Player.AttributeModifiers,
			Inventory = PlayerDataManager.Instance.Player.Inventory,
			Wallet = PlayerDataManager.Instance.Player.Wallet
		};
	}

	private static Inventory LoadPlayerInventory() {
		return new Inventory {
			Items = LoadPlayerProperty<List<InventoryItem>>(_inventoryPath, ItemsFileName),
			Weapons = LoadPlayerProperty<List<InventoryItem>>(_inventoryPath, WeaponsFileName),
			Armors = LoadPlayerProperty<List<InventoryItem>>(_inventoryPath, ArmorsFileName),
			Shields = LoadPlayerProperty<List<InventoryItem>>(_inventoryPath, ShieldsFileName)
		};
	}
	
	public static void CreateCombatTable() {
		var path = Path.Combine(_playerPath, "CombatTable.json");
		File.Create(path).Dispose();
		switch (PlayerDataManager.Instance.Player.PlayerInfo.Class) {
			case Class.Alchemist:
				File.WriteAllText(path, """[{"BAB":0,"Fort":0,"Ref":0,"Will":2},{"BAB":1,"Fort":0,"Ref":0,"Will":3},{"BAB":1,"Fort":1,"Ref":1,"Will":3},{"BAB":2,"Fort":1,"Ref":1,"Will":4},{"BAB":2,"Fort":1,"Ref":1,"Will":4},{"BAB":3,"Fort":2,"Ref":2,"Will":5},{"BAB":3,"Fort":2,"Ref":2,"Will":5},{"BAB":4,"Fort":2,"Ref":2,"Will":6},{"BAB":4,"Fort":3,"Ref":3,"Will":6},{"BAB":5,"Fort":3,"Ref":3,"Will":7},{"BAB":5,"Fort":3,"Ref":3,"Will":7},{"BAB":6,"Fort":4,"Ref":4,"Will":8},{"BAB":6,"Fort":4,"Ref":4,"Will":8},{"BAB":7,"Fort":4,"Ref":4,"Will":9},{"BAB":7,"Fort":5,"Ref":5,"Will":9},{"BAB":8,"Fort":5,"Ref":5,"Will":10},{"BAB":8,"Fort":5,"Ref":5,"Will":10},{"BAB":9,"Fort":6,"Ref":6,"Will":11},{"BAB":9,"Fort":6,"Ref":6,"Will":11},{"BAB":10,"Fort":6,"Ref":6,"Will":12}]""");
			break;
			case Class.Barbarian:
				File.WriteAllText(path, """[{"BAB":1,"Fort":2,"Ref":0,"Will":0},{"BAB":2,"Fort":3,"Ref":0,"Will":0},{"BAB":3,"Fort":3,"Ref":1,"Will":1},{"BAB":4,"Fort":4,"Ref":1,"Will":1},{"BAB":5,"Fort":4,"Ref":1,"Will":1},{"BAB":6,"Fort":5,"Ref":2,"Will":2},{"BAB":7,"Fort":5,"Ref":2,"Will":2},{"BAB":8,"Fort":6,"Ref":2,"Will":2},{"BAB":9,"Fort":6,"Ref":3,"Will":3},{"BAB":10,"Fort":7,"Ref":3,"Will":3},{"BAB":11,"Fort":7,"Ref":3,"Will":3},{"BAB":12,"Fort":8,"Ref":4,"Will":4},{"BAB":13,"Fort":8,"Ref":4,"Will":4},{"BAB":14,"Fort":9,"Ref":4,"Will":4},{"BAB":15,"Fort":9,"Ref":5,"Will":5},{"BAB":16,"Fort":10,"Ref":5,"Will":5},{"BAB":17,"Fort":10,"Ref":5,"Will":5},{"BAB":18,"Fort":11,"Ref":6,"Will":6},{"BAB":19,"Fort":11,"Ref":6,"Will":6},{"BAB":20,"Fort":12,"Ref":6,"Will":6}]""");
			break;
			case Class.Bard:
				File.WriteAllText(path, """[{"BAB":0,"Fort":0,"Ref":2,"Will":2},{"BAB":1,"Fort":0,"Ref":3,"Will":3},{"BAB":2,"Fort":1,"Ref":3,"Will":3},{"BAB":3,"Fort":1,"Ref":4,"Will":4},{"BAB":3,"Fort":1,"Ref":4,"Will":4},{"BAB":4,"Fort":2,"Ref":5,"Will":5},{"BAB":5,"Fort":2,"Ref":5,"Will":5},{"BAB":6,"Fort":2,"Ref":6,"Will":6},{"BAB":6,"Fort":3,"Ref":6,"Will":6},{"BAB":7,"Fort":3,"Ref":7,"Will":7},{"BAB":8,"Fort":3,"Ref":7,"Will":7},{"BAB":9,"Fort":4,"Ref":8,"Will":8},{"BAB":9,"Fort":4,"Ref":8,"Will":8},{"BAB":10,"Fort":4,"Ref":9,"Will":9},{"BAB":11,"Fort":5,"Ref":9,"Will":9},{"BAB":12,"Fort":5,"Ref":10,"Will":10},{"BAB":12,"Fort":5,"Ref":10,"Will":10},{"BAB":13,"Fort":6,"Ref":11,"Will":11},{"BAB":14,"Fort":6,"Ref":11,"Will":11},{"BAB":15,"Fort":6,"Ref":12,"Will":12}]""");
			break;
			case Class.Cavalier:
				File.WriteAllText(path, """[{"BAB":1,"Fort":2,"Ref":0,"Will":0},{"BAB":2,"Fort":3,"Ref":0,"Will":0},{"BAB":3,"Fort":3,"Ref":1,"Will":1},{"BAB":4,"Fort":4,"Ref":1,"Will":1},{"BAB":5,"Fort":4,"Ref":1,"Will":1},{"BAB":6,"Fort":5,"Ref":2,"Will":2},{"BAB":7,"Fort":5,"Ref":2,"Will":2},{"BAB":8,"Fort":6,"Ref":2,"Will":2},{"BAB":9,"Fort":6,"Ref":3,"Will":3},{"BAB":10,"Fort":7,"Ref":3,"Will":3},{"BAB":11,"Fort":7,"Ref":3,"Will":3},{"BAB":12,"Fort":8,"Ref":4,"Will":4},{"BAB":13,"Fort":8,"Ref":4,"Will":4},{"BAB":14,"Fort":9,"Ref":4,"Will":4},{"BAB":15,"Fort":9,"Ref":5,"Will":5},{"BAB":16,"Fort":10,"Ref":5,"Will":5},{"BAB":17,"Fort":10,"Ref":5,"Will":5},{"BAB":18,"Fort":11,"Ref":6,"Will":6},{"BAB":19,"Fort":11,"Ref":6,"Will":6},{"BAB":20,"Fort":12,"Ref":6,"Will":6}]""");
			break;
			case Class.Cleric:
				File.WriteAllText(path, """[{"BAB":0,"Fort":2,"Ref":0,"Will":2},{"BAB":1,"Fort":3,"Ref":0,"Will":3},{"BAB":2,"Fort":3,"Ref":1,"Will":3},{"BAB":3,"Fort":4,"Ref":1,"Will":4},{"BAB":3,"Fort":4,"Ref":1,"Will":4},{"BAB":4,"Fort":5,"Ref":2,"Will":5},{"BAB":5,"Fort":5,"Ref":2,"Will":5},{"BAB":6,"Fort":6,"Ref":2,"Will":6},{"BAB":6,"Fort":6,"Ref":3,"Will":6},{"BAB":7,"Fort":7,"Ref":3,"Will":7},{"BAB":8,"Fort":7,"Ref":3,"Will":7},{"BAB":9,"Fort":8,"Ref":4,"Will":8},{"BAB":9,"Fort":8,"Ref":4,"Will":8},{"BAB":10,"Fort":9,"Ref":4,"Will":9},{"BAB":11,"Fort":9,"Ref":5,"Will":9},{"BAB":12,"Fort":10,"Ref":5,"Will":10},{"BAB":12,"Fort":10,"Ref":5,"Will":10},{"BAB":13,"Fort":11,"Ref":6,"Will":11},{"BAB":14,"Fort":11,"Ref":6,"Will":11},{"BAB":15,"Fort":12,"Ref":6,"Will":12}]""");
			break;
			case Class.Druid:
				File.WriteAllText(path, """[{"BAB":0,"Fort":2,"Ref":0,"Will":2},{"BAB":1,"Fort":3,"Ref":0,"Will":3},{"BAB":2,"Fort":3,"Ref":1,"Will":3},{"BAB":3,"Fort":4,"Ref":1,"Will":4},{"BAB":3,"Fort":4,"Ref":1,"Will":4},{"BAB":4,"Fort":5,"Ref":2,"Will":5},{"BAB":5,"Fort":5,"Ref":2,"Will":5},{"BAB":6,"Fort":6,"Ref":2,"Will":6},{"BAB":6,"Fort":6,"Ref":3,"Will":6},{"BAB":7,"Fort":7,"Ref":3,"Will":7},{"BAB":8,"Fort":7,"Ref":3,"Will":7},{"BAB":9,"Fort":8,"Ref":4,"Will":8},{"BAB":9,"Fort":8,"Ref":4,"Will":8},{"BAB":10,"Fort":9,"Ref":4,"Will":9},{"BAB":11,"Fort":9,"Ref":5,"Will":9},{"BAB":12,"Fort":10,"Ref":5,"Will":10},{"BAB":12,"Fort":10,"Ref":5,"Will":10},{"BAB":13,"Fort":11,"Ref":6,"Will":11},{"BAB":14,"Fort":11,"Ref":6,"Will":11},{"BAB":15,"Fort":12,"Ref":6,"Will":12}]""");
			break;
			case Class.Fighter:
				File.WriteAllText(path, """[{"BAB":1,"Fort":2,"Ref":0,"Will":0},{"BAB":2,"Fort":3,"Ref":0,"Will":0},{"BAB":3,"Fort":3,"Ref":1,"Will":1},{"BAB":4,"Fort":4,"Ref":1,"Will":1},{"BAB":5,"Fort":4,"Ref":1,"Will":1},{"BAB":6,"Fort":5,"Ref":2,"Will":2},{"BAB":7,"Fort":5,"Ref":2,"Will":2},{"BAB":8,"Fort":6,"Ref":2,"Will":2},{"BAB":9,"Fort":6,"Ref":3,"Will":3},{"BAB":10,"Fort":7,"Ref":3,"Will":3},{"BAB":11,"Fort":7,"Ref":3,"Will":3},{"BAB":12,"Fort":8,"Ref":4,"Will":4},{"BAB":13,"Fort":8,"Ref":4,"Will":4},{"BAB":14,"Fort":9,"Ref":4,"Will":4},{"BAB":15,"Fort":9,"Ref":5,"Will":5},{"BAB":16,"Fort":10,"Ref":5,"Will":5},{"BAB":17,"Fort":10,"Ref":5,"Will":5},{"BAB":18,"Fort":11,"Ref":6,"Will":6},{"BAB":19,"Fort":11,"Ref":6,"Will":6},{"BAB":20,"Fort":12,"Ref":6,"Will":6}]""");
			break;
			case Class.Inquisitor:
				File.WriteAllText(path, """[{"BAB":1,"Fort":2,"Ref":0,"Will":2},{"BAB":2,"Fort":3,"Ref":0,"Will":3},{"BAB":3,"Fort":3,"Ref":1,"Will":3},{"BAB":3,"Fort":4,"Ref":1,"Will":4},{"BAB":4,"Fort":4,"Ref":1,"Will":4},{"BAB":5,"Fort":5,"Ref":2,"Will":5},{"BAB":6,"Fort":5,"Ref":2,"Will":5},{"BAB":6,"Fort":6,"Ref":2,"Will":6},{"BAB":7,"Fort":6,"Ref":3,"Will":6},{"BAB":8,"Fort":7,"Ref":3,"Will":7},{"BAB":9,"Fort":7,"Ref":3,"Will":7},{"BAB":9,"Fort":8,"Ref":4,"Will":8},{"BAB":10,"Fort":8,"Ref":4,"Will":8},{"BAB":11,"Fort":9,"Ref":4,"Will":9},{"BAB":11,"Fort":9,"Ref":5,"Will":9},{"BAB":12,"Fort":10,"Ref":5,"Will":10},{"BAB":12,"Fort":10,"Ref":5,"Will":10},{"BAB":13,"Fort":11,"Ref":6,"Will":11},{"BAB":14,"Fort":11,"Ref":6,"Will":11},{"BAB":15,"Fort":12,"Ref":6,"Will":12}]""");
			break;
			case Class.Monk:
				File.WriteAllText(path, """[{"BAB":0,"Fort":2,"Ref":2,"Will":2},{"BAB":1,"Fort":3,"Ref":3,"Will":3},{"BAB":2,"Fort":3,"Ref":3,"Will":3},{"BAB":3,"Fort":4,"Ref":4,"Will":4},{"BAB":3,"Fort":4,"Ref":4,"Will":4},{"BAB":4,"Fort":5,"Ref":5,"Will":5},{"BAB":5,"Fort":5,"Ref":5,"Will":5},{"BAB":6,"Fort":6,"Ref":6,"Will":6},{"BAB":6,"Fort":6,"Ref":6,"Will":6},{"BAB":7,"Fort":7,"Ref":7,"Will":7},{"BAB":8,"Fort":7,"Ref":7,"Will":7},{"BAB":9,"Fort":8,"Ref":8,"Will":8},{"BAB":9,"Fort":8,"Ref":8,"Will":8},{"BAB":10,"Fort":9,"Ref":9,"Will":9},{"BAB":11,"Fort":9,"Ref":9,"Will":9},{"BAB":12,"Fort":10,"Ref":10,"Will":10},{"BAB":12,"Fort":10,"Ref":10,"Will":10},{"BAB":13,"Fort":11,"Ref":11,"Will":11},{"BAB":14,"Fort":11,"Ref":11,"Will":11},{"BAB":15,"Fort":12,"Ref":12,"Will":12}]""");
			break;
			case Class.Oracle:
				File.WriteAllText(path, """[{"BAB":1,"Fort":0,"Ref":0,"Will":2},{"BAB":2,"Fort":0,"Ref":0,"Will":3},{"BAB":3,"Fort":1,"Ref":1,"Will":3},{"BAB":3,"Fort":1,"Ref":1,"Will":4},{"BAB":4,"Fort":1,"Ref":1,"Will":4},{"BAB":5,"Fort":2,"Ref":2,"Will":5},{"BAB":6,"Fort":2,"Ref":2,"Will":5},{"BAB":6,"Fort":2,"Ref":2,"Will":6},{"BAB":7,"Fort":3,"Ref":3,"Will":6},{"BAB":8,"Fort":3,"Ref":3,"Will":7},{"BAB":9,"Fort":3,"Ref":3,"Will":7},{"BAB":9,"Fort":4,"Ref":4,"Will":8},{"BAB":10,"Fort":4,"Ref":4,"Will":8},{"BAB":11,"Fort":4,"Ref":4,"Will":9},{"BAB":11,"Fort":5,"Ref":5,"Will":9},{"BAB":12,"Fort":5,"Ref":5,"Will":10},{"BAB":12,"Fort":5,"Ref":5,"Will":10},{"BAB":13,"Fort":6,"Ref":6,"Will":11},{"BAB":14,"Fort":6,"Ref":6,"Will":11},{"BAB":15,"Fort":6,"Ref":6,"Will":12}]""");
			break;
			case Class.Paladin:
				File.WriteAllText(path, """[{"BAB":1,"Fort":2,"Ref":0,"Will":2},{"BAB":2,"Fort":3,"Ref":0,"Will":3},{"BAB":3,"Fort":3,"Ref":1,"Will":3},{"BAB":4,"Fort":4,"Ref":1,"Will":4},{"BAB":5,"Fort":4,"Ref":1,"Will":4},{"BAB":6,"Fort":5,"Ref":2,"Will":5},{"BAB":7,"Fort":5,"Ref":2,"Will":5},{"BAB":8,"Fort":6,"Ref":2,"Will":6},{"BAB":9,"Fort":6,"Ref":3,"Will":6},{"BAB":10,"Fort":7,"Ref":3,"Will":7},{"BAB":11,"Fort":7,"Ref":3,"Will":7},{"BAB":12,"Fort":8,"Ref":4,"Will":8},{"BAB":13,"Fort":8,"Ref":4,"Will":8},{"BAB":14,"Fort":9,"Ref":4,"Will":9},{"BAB":15,"Fort":9,"Ref":5,"Will":9},{"BAB":16,"Fort":10,"Ref":5,"Will":10},{"BAB":17,"Fort":10,"Ref":5,"Will":10},{"BAB":18,"Fort":11,"Ref":6,"Will":11},{"BAB":19,"Fort":11,"Ref":6,"Will":11},{"BAB":20,"Fort":12,"Ref":6,"Will":12}]""");
			break;
			case Class.Ranger:
				File.WriteAllText(path, """[{"BAB":1,"Fort":2,"Ref":2,"Will":0},{"BAB":2,"Fort":3,"Ref":3,"Will":0},{"BAB":3,"Fort":3,"Ref":3,"Will":1},{"BAB":4,"Fort":4,"Ref":4,"Will":1},{"BAB":5,"Fort":4,"Ref":4,"Will":1},{"BAB":6,"Fort":5,"Ref":5,"Will":2},{"BAB":7,"Fort":5,"Ref":5,"Will":2},{"BAB":8,"Fort":6,"Ref":6,"Will":2},{"BAB":9,"Fort":6,"Ref":6,"Will":3},{"BAB":10,"Fort":7,"Ref":7,"Will":3},{"BAB":11,"Fort":7,"Ref":7,"Will":3},{"BAB":12,"Fort":8,"Ref":8,"Will":4},{"BAB":13,"Fort":8,"Ref":8,"Will":4},{"BAB":14,"Fort":9,"Ref":9,"Will":4},{"BAB":15,"Fort":9,"Ref":9,"Will":5},{"BAB":16,"Fort":10,"Ref":10,"Will":5},{"BAB":17,"Fort":10,"Ref":10,"Will":5},{"BAB":18,"Fort":11,"Ref":11,"Will":6},{"BAB":19,"Fort":11,"Ref":11,"Will":6},{"BAB":20,"Fort":12,"Ref":12,"Will":6}]""");
			break;
			case Class.Rogue:
				File.WriteAllText(path, """[{"BAB":1,"Fort":2,"Ref":2,"Will":0},{"BAB":2,"Fort":3,"Ref":3,"Will":0},{"BAB":3,"Fort":3,"Ref":3,"Will":1},{"BAB":4,"Fort":4,"Ref":4,"Will":1},{"BAB":5,"Fort":4,"Ref":4,"Will":1},{"BAB":6,"Fort":5,"Ref":5,"Will":2},{"BAB":7,"Fort":5,"Ref":5,"Will":2},{"BAB":8,"Fort":6,"Ref":6,"Will":2},{"BAB":9,"Fort":6,"Ref":6,"Will":3},{"BAB":10,"Fort":7,"Ref":7,"Will":3},{"BAB":11,"Fort":7,"Ref":7,"Will":3},{"BAB":12,"Fort":8,"Ref":8,"Will":4},{"BAB":13,"Fort":8,"Ref":8,"Will":4},{"BAB":14,"Fort":9,"Ref":9,"Will":4},{"BAB":15,"Fort":9,"Ref":9,"Will":5},{"BAB":16,"Fort":10,"Ref":10,"Will":5},{"BAB":17,"Fort":10,"Ref":10,"Will":5},{"BAB":18,"Fort":11,"Ref":11,"Will":6},{"BAB":19,"Fort":11,"Ref":11,"Will":6},{"BAB":20,"Fort":12,"Ref":12,"Will":6}]""");
			break;
			case Class.Sorcerer:
				File.WriteAllText(path, """[{"BAB":0,"Fort":0,"Ref":0,"Will":2},{"BAB":1,"Fort":0,"Ref":0,"Will":3},{"BAB":1,"Fort":1,"Ref":1,"Will":3},{"BAB":2,"Fort":1,"Ref":1,"Will":4},{"BAB":2,"Fort":1,"Ref":1,"Will":4},{"BAB":3,"Fort":2,"Ref":2,"Will":5},{"BAB":3,"Fort":2,"Ref":2,"Will":5},{"BAB":4,"Fort":2,"Ref":2,"Will":6},{"BAB":4,"Fort":3,"Ref":3,"Will":6},{"BAB":5,"Fort":3,"Ref":3,"Will":7},{"BAB":5,"Fort":3,"Ref":3,"Will":7},{"BAB":6,"Fort":4,"Ref":4,"Will":8},{"BAB":6,"Fort":4,"Ref":4,"Will":8},{"BAB":7,"Fort":4,"Ref":4,"Will":9},{"BAB":7,"Fort":5,"Ref":5,"Will":9},{"BAB":8,"Fort":5,"Ref":5,"Will":10},{"BAB":8,"Fort":5,"Ref":5,"Will":10},{"BAB":9,"Fort":6,"Ref":6,"Will":11},{"BAB":9,"Fort":6,"Ref":6,"Will":11},{"BAB":10,"Fort":6,"Ref":6,"Will":12}]""");
			break;
			case Class.Summoner:
				File.WriteAllText(path, """[{"BAB":1,"Fort":0,"Ref":0,"Will":2},{"BAB":2,"Fort":0,"Ref":0,"Will":3},{"BAB":3,"Fort":1,"Ref":1,"Will":3},{"BAB":3,"Fort":1,"Ref":1,"Will":4},{"BAB":4,"Fort":1,"Ref":1,"Will":4},{"BAB":5,"Fort":2,"Ref":2,"Will":5},{"BAB":6,"Fort":2,"Ref":2,"Will":5},{"BAB":6,"Fort":2,"Ref":2,"Will":6},{"BAB":7,"Fort":3,"Ref":3,"Will":6},{"BAB":8,"Fort":3,"Ref":3,"Will":7},{"BAB":9,"Fort":3,"Ref":3,"Will":7},{"BAB":9,"Fort":4,"Ref":4,"Will":8},{"BAB":10,"Fort":4,"Ref":4,"Will":8},{"BAB":11,"Fort":4,"Ref":4,"Will":9},{"BAB":11,"Fort":5,"Ref":5,"Will":9},{"BAB":12,"Fort":5,"Ref":5,"Will":10},{"BAB":12,"Fort":5,"Ref":5,"Will":10},{"BAB":13,"Fort":6,"Ref":6,"Will":11},{"BAB":14,"Fort":6,"Ref":6,"Will":11},{"BAB":15,"Fort":6,"Ref":6,"Will":12}]""");
			break;
			case Class.Witch:
				File.WriteAllText(path, """[{"BAB":0,"Fort":0,"Ref":0,"Will":2},{"BAB":1,"Fort":0,"Ref":0,"Will":3},{"BAB":1,"Fort":1,"Ref":1,"Will":3},{"BAB":2,"Fort":1,"Ref":1,"Will":4},{"BAB":2,"Fort":1,"Ref":1,"Will":4},{"BAB":3,"Fort":2,"Ref":2,"Will":5},{"BAB":3,"Fort":2,"Ref":2,"Will":5},{"BAB":4,"Fort":2,"Ref":2,"Will":6},{"BAB":4,"Fort":3,"Ref":3,"Will":6},{"BAB":5,"Fort":3,"Ref":3,"Will":7},{"BAB":5,"Fort":3,"Ref":3,"Will":7},{"BAB":6,"Fort":4,"Ref":4,"Will":8},{"BAB":6,"Fort":4,"Ref":4,"Will":8},{"BAB":7,"Fort":4,"Ref":4,"Will":9},{"BAB":7,"Fort":5,"Ref":5,"Will":9},{"BAB":8,"Fort":5,"Ref":5,"Will":10},{"BAB":8,"Fort":5,"Ref":5,"Will":10},{"BAB":9,"Fort":6,"Ref":6,"Will":11},{"BAB":9,"Fort":6,"Ref":6,"Will":11},{"BAB":10,"Fort":6,"Ref":6,"Will":12}]""");
			break;
			case Class.Wizard:
				File.WriteAllText(path, """[{"BAB":0,"Fort":0,"Ref":0,"Will":2},{"BAB":1,"Fort":0,"Ref":0,"Will":3},{"BAB":1,"Fort":1,"Ref":1,"Will":3},{"BAB":2,"Fort":1,"Ref":1,"Will":4},{"BAB":2,"Fort":1,"Ref":1,"Will":4},{"BAB":3,"Fort":2,"Ref":2,"Will":5},{"BAB":3,"Fort":2,"Ref":2,"Will":5},{"BAB":4,"Fort":2,"Ref":2,"Will":6},{"BAB":4,"Fort":3,"Ref":3,"Will":6},{"BAB":5,"Fort":3,"Ref":3,"Will":7},{"BAB":5,"Fort":3,"Ref":3,"Will":7},{"BAB":6,"Fort":4,"Ref":4,"Will":8},{"BAB":6,"Fort":4,"Ref":4,"Will":8},{"BAB":7,"Fort":4,"Ref":4,"Will":9},{"BAB":7,"Fort":5,"Ref":5,"Will":9},{"BAB":8,"Fort":5,"Ref":5,"Will":10},{"BAB":8,"Fort":5,"Ref":5,"Will":10},{"BAB":9,"Fort":6,"Ref":6,"Will":11},{"BAB":9,"Fort":6,"Ref":6,"Will":11},{"BAB":10,"Fort":6,"Ref":6,"Will":12}]""");
			break;
		}
		
		var combatTable = JsonSerializer.Deserialize<CombatTableRow[]>(File.ReadAllText(path));
		if (combatTable == null) return;
		PlayerDataManager.Instance.Player.CombatInfo.BaseAttackBonus = combatTable[0].BAB;
		PlayerDataManager.Instance.Player.CombatInfo.Fortitude = combatTable[0].Fort;
		PlayerDataManager.Instance.Player.CombatInfo.Reflex = combatTable[0].Ref;
		PlayerDataManager.Instance.Player.CombatInfo.Will = combatTable[0].Will;
	}
	
	private static void WritePlayerProperty<T>(T o, string fileName) {
		var path = Path.Combine(_playerPath, fileName);
		File.Create(path).Dispose();
		var json = JsonSerializer.Serialize(o, Options);
		File.WriteAllText(path, json);
		
		if(DebugMode)
			Console.WriteLine($"Successfully written player attribute mods to {path}");
	}
	
	private static void WritePlayerProperty<T>(T o, string path, string fileName) {
		var finalPath = Path.Combine(path, fileName);
		File.Create(finalPath).Dispose();
		var json = JsonSerializer.Serialize(o, Options);
		File.WriteAllText(finalPath, json);
		
		if(DebugMode)
			Console.WriteLine($"Successfully written player attribute mods to {finalPath}");
	}

	private static T LoadPlayerProperty<T>(string fileName) {
		var path = Path.Combine(_playerPath, fileName);
		var json = File.ReadAllText(path);
		
		if (DebugMode) 
			Console.WriteLine($"Loaded file text: " + json);
		
		return JsonSerializer.Deserialize<T>(json, Options);

	}
	
	private static T LoadPlayerProperty<T>(string path, string fileName) {
		var finalPath = Path.Combine(path, fileName);
		var json = File.ReadAllText(finalPath);
		
		if (DebugMode) 
			Console.WriteLine($"Loaded file text: " + json);
		
		return JsonSerializer.Deserialize<T>(json, Options);

	}
	
	#endregion

	#region General File Management

	private static void SerializeToFile(string path, object obj) {
			var jsonString = JsonSerializer.Serialize(obj, Options);

			if (File.Exists(path)) {
				Console.WriteLine($"File already exists at {path}\nOverwrite? [Y/N]");
				var ans = Console.ReadLine() ?? throw new InvalidOperationException();
				if (string.Equals(ans, "N", StringComparison.OrdinalIgnoreCase))
					return;
				if (!string.Equals(ans, "Y", StringComparison.OrdinalIgnoreCase)) return;
				try {
					File.Create(path).Dispose();
					File.WriteAllText(path, jsonString);

					Console.WriteLine($"File successfully created at {path}");
				}
				catch (Exception e) {
					Console.WriteLine(e);
				}
			} else {
				File.Create(path).Close();
				File.WriteAllText(path, jsonString);

				if(DebugMode)
					Console.WriteLine($"File successfully created at {path}");
			}
	}
	
	private static void WriteToFile(string path, string data) {
		if (File.Exists(path)) {
			Console.WriteLine($"File already exists at {path}\nOverwrite? [Y/N]");
			var ans = Console.ReadLine() ?? throw new InvalidOperationException();
			if (string.Equals(ans, "N", StringComparison.OrdinalIgnoreCase))
				return;
			if (!string.Equals(ans, "Y", StringComparison.OrdinalIgnoreCase)) return;
			try {
				File.Create(path).Close();
				File.WriteAllText(path, data);

				Console.WriteLine($"File successfully created at {path}");
			}
			catch (Exception e) {
				Console.WriteLine(e);
			}
		} else {
			File.Create(path).Dispose();
			File.WriteAllText(path, data);

			if(DebugMode)
				Console.WriteLine($"File successfully created at {path}");
		}
	}
	
	#endregion
}