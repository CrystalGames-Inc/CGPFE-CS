using CGPFE.Data.Constants;

namespace CGPFE.God.Creation.Player.Properties;

public class PlayerInfo {
	public string Name { get; set; }
	public Gender Gender { get; set; }
	public Alignment Alignment { get; set; }
	public int Age { get; set; }
	public Race Race { get; set; }
	public Size Size { get; set; }
	public int SizeMod { get; set; }
	public Class Class { get; set; }
	
	public int Level { get; set; }
	public int Xp { get; set; }
	public int MaxHealth { get; set; }
	public int Health { get; set; }
}