using CGPFE.Core.Enums;
using CGPFE.Core.Utilities;
using CGPFE.Domain.World;

namespace CGPFE.Management;

public class WorldManager {
	public GameWorld World = new GameWorld("Placeholder");
	
	private static WorldManager _instance = null;
	private static readonly object Padlock = new object();

	public static WorldManager Instance {
		get {
			lock (Padlock) {
				_instance ??= new WorldManager();
			}
			return _instance;
		}
	}

	public void RegisterWorld() {
		while (true) {
			Console.WriteLine("Please choose a name for the game world: ");
			var name = Console.ReadLine();
			if (string.IsNullOrEmpty(name)) {
				Console.WriteLine("Must enter a name");
				continue;
			}
			World.WorldName = name;
			break;
		}
	}

	public void RegisterNewRegion() {
		string name;
		while (true) {
			Console.WriteLine("Please choose a name for the region: ");
			name = Console.ReadLine();
			if (string.IsNullOrEmpty(name)) {
				Console.WriteLine("Must enter a name");
				continue;
			}
			break;
		}
		
		Terrain terrain;
		terrain = PromptHelper.EnumPrompt<Terrain>("Please enter a terrain type: ");
		
		
	}
}