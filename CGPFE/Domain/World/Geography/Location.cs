using CGPFE.Core.Enums;

namespace CGPFE.Domain.World.Geography;

public class Location(string name, Terrain? terrainType, Climate? climate) {
	public bool Discovered = false;
	public string Name = name;
	public Terrain? TerrainType = terrainType;
	public Climate? ClimateType = climate;

	public void Discover() {
		Discovered = true;
	}
}