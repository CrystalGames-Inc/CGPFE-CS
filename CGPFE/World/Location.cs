using CGPFE.Data.Constants;

namespace CGPFE.World;

public abstract class Location(string name, Terrain? terrainType, Climate? climate) {
	public string Name = name;
	public Terrain? TerrainType = terrainType;
	public Climate? ClimateType = climate;
}