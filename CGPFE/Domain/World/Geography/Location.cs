using CGPFE.Core.Enums;

namespace CGPFE.Domain.World.Geography;

public class Location(string name, Terrain? terrainType, Climate? climateType)
{
	public bool Discovered;
	public string Name = name;
	public Terrain? TerrainType = terrainType;
	public Climate? ClimateType = climateType;

	public void Discover() {
		Discovered = true;
	}
}