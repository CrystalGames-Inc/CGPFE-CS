using CGPFE.Core.Enums;
using CGPFE.Domain.World.Geography.Writables;
using CGPFE.Domain.World.Settlements;
using CGPFE.Mechanics;

namespace CGPFE.Domain.World.Geography;

public class Region(string name, Terrain terrainType, Climate climate) : Location(name, terrainType, climate) {
	
	//Region Data
	public new string Name = name;
	public new Terrain TerrainType = terrainType;
	public Climate Climate = climate;
	
	//Locations
	public List<Location>? Locations;
	public List<string>? LocationNames;
	
	public Dictionary<Region, int>? BorderingRegions = new();

	public void AddLocation(Location location) {
		Locations ??= [];
		Locations.Add(location);
		
		LocationNames ??= [];
		LocationNames.Add(location.Name);
	}

	public bool HasLocation(Location location) {
		return Locations != null && Locations.Contains(location);
	}

	public Location? GetMatchingLocation(string locationName) {
		if (LocationNames != null) return Locations.FirstOrDefault(r => locationName.Equals(r.Name));
		
		Console.WriteLine("No regions in the world");
		return null;
	}

	public void MatchRegion(WRegion region) {
		Name = region.Name;
		TerrainType = region.TerrainType;
		Climate = region.Climate;
	}
	
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
		if (Locations == null) {
			Console.WriteLine($"No settlements in {Name}");
			return;
		}
		
		List<Location> settlements = [];
		foreach (var l in Locations) {
			if(l.GetType() == typeof(Settlement))
				settlements.Add(l);
		}

		Console.WriteLine($"Settlements in {Name}:");
		for (var i = 0; i < settlements.Count; i++) {
			Console.WriteLine($"{i}. {settlements[i].Name}");
		}
	}
}