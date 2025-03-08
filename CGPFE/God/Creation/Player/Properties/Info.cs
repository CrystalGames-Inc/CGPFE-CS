using CGPFE.Data.Constants;

namespace CGPFE.God.Creation.Player.Properties;

public class Info {
	
	#region Characteristics
	
	public string Name { get; set; } = "Nameless";
	public Gender Gender { get; set; } = Gender.MALE;
	public Alignment Alignment { get; set; } = Alignment.NEUTRAL;
	public int Age { get; set; } = 0;
	public Race Race { get; set; } = Race.NONE;
	public Size Size { get; set; } = Size.MEDIUM;
	public int SizeMod { get; set; } = 0;
	public Class Class { get; set; } = Class.NONE;

	#endregion
	
	#region Data
	
	public int Level { get; set; } = 0;
	public int Xp { get; set; } = 0;
	public int MaxHealth { get; set; } = 0;
	public int Health { get; set; } = 0;

	#endregion
}