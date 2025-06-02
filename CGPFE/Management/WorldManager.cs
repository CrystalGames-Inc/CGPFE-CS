using CGPFE.Core.Enums;
using CGPFE.Core.Utilities;
using CGPFE.Domain.World;
using CGPFE.Domain.World.Geography;

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
		World.WorldName = PromptHelper.TextPrompt("Please choose a name for the world: ");

		if (PromptHelper.YesNoPrompt("Would you also like to start creating regions? ", true))
			RegisterNewRegion();
	}

	public Region RegisterNewRegion() {
		var name = PromptHelper.TextPrompt("Please enter a name for the region: ");
		
		var terrain = PromptHelper.EnumPrompt<Terrain>("Please enter a terrain type: ");
		
		var climate = PromptHelper.EnumPrompt<Climate>("Please enter a climate type: ");
		
		var r = new Region(name, terrain, climate);
		
		World.AddRegion(r);

		return r;
	}
}