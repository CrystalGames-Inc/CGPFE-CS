using CGPFE.Data.Constants;

namespace CGPFE.World;

public class Region(string name, Terrain terrainType, Climate climate) {
	public readonly string Name = name;
	public readonly Terrain TerrainType = terrainType;
	public readonly Climate Climate = climate;
	private List<Location>? _locations;
	private List<Settlement.Settlement>? _settlements;

	public void AddLocation(Location location) {
		_locations ??= [];
		_locations.Add(location);
	}

	public void AddSettlement(Settlement.Settlement settlement) {
		_settlements ??= [];
		_settlements.Add(settlement);
	}
	
	public void DisplayLocations() {
		if (_locations == null) {
			Console.WriteLine($"No special locations in {Name}");
			return;
		}
		Console.WriteLine($"Locations in {Name}:");
		foreach (var l in _locations) {
			Console.WriteLine(l.Name);
		}
	}

	public void DisplaySettlements() {
		if (_settlements == null) {
			Console.WriteLine("No settlements in the region");
			return;
		}
		Console.WriteLine($"Settlements in {Name}:");
		foreach (var s in _settlements) {
			Console.WriteLine(s.Info.Name);
		}
	}
}