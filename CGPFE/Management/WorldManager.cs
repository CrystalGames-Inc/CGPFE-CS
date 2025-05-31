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
		
	}
	
	
}