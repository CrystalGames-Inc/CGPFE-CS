using CGPFE.Core.Enums;
using CGPFE.Domain.World.Settlements;
using CGPFE.Mechanics;

namespace CGPFE.Domain.World.Geography;

public class Region(string name, Terrain terrainType, Climate climate) : Location(name, terrainType, climate) {
	public readonly string Name = name;
	public readonly Terrain TerrainType = terrainType;
	public readonly Climate Climate = climate;
	public List<Location>? Locations = [];
	public List<Settlement>? Settlements = [];
	public Dictionary<Region, int>? BorderingRegions = new();

	public void DisplayNeighbouringRegions() {
		if (BorderingRegions == null) {
			Console.WriteLine($"No bordering regions for region {Name}");
			return;
		}

		Console.WriteLine($"Bordering regions for {Name}:");
		foreach (var region in BorderingRegions) {
			Console.WriteLine($"{region.Key.Name}: {Compass.ToDirection(region.Value)}");
		}
	}
	
	public void DisplayLocations() {
		if (Locations == null) {
			Console.WriteLine($"No special locations in {Name}");
			return;
		}
		Console.WriteLine($"Locations in {Name}:");
		foreach (var l in Locations.Where(l => l.Discovered)) {
			Console.WriteLine(l.Name);
		}
	}

	public void DisplaySettlements() {
		if (Settlements == null) {
			Console.WriteLine("No settlements in the region");
			return;
		}
		Console.WriteLine($"Settlements in {Name}:");
		foreach (var s in Settlements.Where(s => s.Discovered))
			Console.WriteLine(s.Info.Name);
	}
}