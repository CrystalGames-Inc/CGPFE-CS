using CGPFE.Core.Enums;

namespace CGPFE.Domain.World.Geography.Writables;

public class WRegion(string name, Terrain terrainType, Climate climate) {
	public readonly string Name = name;
	public readonly Terrain TerrainType = terrainType;
	public readonly Climate Climate = climate;
}