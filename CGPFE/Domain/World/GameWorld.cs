﻿using CGPFE.Domain.World.Geography;

namespace CGPFE.Domain.World;

public class GameWorld(string worldName) {
	
	public string WorldName = worldName;

	private List<Region>? _regions;

	public void AddRegion(Region region) {
		_regions ??= [];
		_regions.Add(region);
	}

	public void RemoveRegion(Region region) {
		_regions?.Remove(region);
	}

	public void DisplayRegions() {
		if (_regions != null)
			foreach (var r in _regions) {
				Console.WriteLine(r.Name);
			}
		else {
			Console.WriteLine("No regions in the world");
		}
	}

	bool HasRegion(Region region) {
		return _regions != null && _regions.Contains(region);
	}

	public Region GetRegion(Region r) {
		if(HasRegion(r))
			return r;
		
		Console.WriteLine($"Region {r.Name} does not exist in the world");
		return null;
		
	}

	public void DisplayRegionInfo(Region region) {
		if (!HasRegion(region)) return;
		Console.WriteLine("Info for " + region.Name + ": ");
		Console.WriteLine(" Climate Type: " + region.Climate);
		Console.WriteLine(" Terrain Type: " + region.TerrainType);
	}
}