using CGPFE.Core.Enums;

namespace CGPFE.Mechanics;

public static class Compass {
	public static float North => 0f;
	public static float East => 90f;
	public static float South => 180f;
	public static float West => 270f;

	public static float Normalize(float angle) {
		return (angle % 360 + 360) % 360;
	}

	public static Direction ToDirection(float angle) {
		angle = Normalize(angle);
		if(angle < 22.5 || angle >= 337.5) return Direction.North;
		if(angle < 67.5) return Direction.NorthEast;
		if(angle < 112.5) return Direction.East;
		if(angle < 157.5) return Direction.SouthEast;
		if(angle < 202.5) return Direction.South;
		if(angle < 247.5) return Direction.SouthWest;
		if (angle < 292.5) return Direction.West;
		return Direction.NorthWest;
	}
}