using CGPFE.Domain.World.Geography;

namespace CGPFE.Domain.World;

public class GameWorld {
	
	public string WorldName;

	public List<Region>? Regions;
	public List<string>? RegionNames;

	public List<string>? NpcNames;

	public void AddRegion(Region region) {
		Regions ??= [];
		Regions.Add(region);
		RegionNames ??= [];
		RegionNames.Add(region.Name);
	}

	public GameWorld() {
		
	}

	public GameWorld(string worldName) {
		WorldName = worldName;
	}

	public void RemoveRegion(Region region) {
		Regions?.Remove(region);
		RegionNames?.Remove(region.Name);
	}

	public void DisplayRegions() {
		if (RegionNames != null) {
			Console.WriteLine($"Regions in {WorldName}");
			foreach (var r in RegionNames) {
				Console.WriteLine(r);
			}

			return;
		}
		Console.WriteLine("No regions in the world");
	}

	public bool HasRegion(Region region) {
		return Regions != null && Regions.Contains(region);
	}

	public Region? GetMatchingRegion(string regionName) {
		if (RegionNames != null) return Regions.FirstOrDefault(r => regionName.Equals(r.Name));
		
		Console.WriteLine("No regions in the world");
		return null;
	}

	public void DisplayRegionInfo(Region region) {
		if (!HasRegion(region)) return;
		Console.WriteLine("Info for " + region.Name + ": ");
		Console.WriteLine(" Climate Type: " + region.Climate);
		Console.WriteLine(" Terrain Type: " + region.TerrainType);
	}
}