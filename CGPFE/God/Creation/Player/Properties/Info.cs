using CGPFE.Data.Constants;

namespace CGPFE.God.Creation.Player.Properties;

public struct PlayerInfo {
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