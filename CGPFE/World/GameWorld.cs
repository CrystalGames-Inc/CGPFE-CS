using System.Diagnostics.CodeAnalysis;

namespace CGPFE.World;

public abstract class GameWorld(string worldName, List<Region> regions, List<Location>? locations) {
	
	public string WorldName = worldName;

	public List<Region> Regions = regions;
	public List<Location>? Locations = locations;
}