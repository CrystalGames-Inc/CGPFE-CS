using CGPFE.Data.Constants;

namespace CGPFE.God.Creation.Player.Properties;

public class Info {
	
	#region Characteristics
	
	public string Name { get; set; } = "Nameless";
	public Gender Gender { get; set; } = Gender.Male;
	public Alignment Alignment { get; set; } = Alignment.Neutral;
	public int Age { get; set; } = 0;
	public Race Race { get; set; } = Race.None;
	public Size Size { get; set; } = Size.Medium;
	public int SizeMod { get; set; } = 0;
	public Class Class { get; set; } = Class.None;

	#endregion
	
	#region Data
	
	public int Level { get; set; } = 0;
	public int Xp { get; set; } = 0;
	public int MaxHealth { get; set; } = 0;
	public int Health { get; set; } = 0;

	#endregion
}

public struct PlayerInfo() {
	public string Name;
	public Gender Gender;
	public Alignment Alignment;
	public int Age;
	public Race Race;
	public Size Size;
	public int SizeMod;
	public Class Class;
	
	public int Level;
	public int Xp;
	public int MaxHealth;
	public int Health;
}