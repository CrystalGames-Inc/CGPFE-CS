using CGPFE.Data.Constants;

namespace CGPFE.World;

public abstract class Region(string name, Terrain terrainType, Climate climate) {
	public string Name = name;
	public Terrain TerrainType = terrainType;
	public Climate Climate = climate;
	public List<Location>? Locations;
}