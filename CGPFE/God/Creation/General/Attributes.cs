namespace CGPFE.God.Creation.General;

public class Attributes {
	public int Strength { get; set; }
	public int Dexterity { get; set; }
	public int Constitution { get; set; }
	public int Intelligence { get; set; }
	public int Wisdom { get; set; }
	public int Charisma { get; set; }
	public int MoveSpeed { get; set; }

	public Attributes() {
		Strength = 0;
		Dexterity = 0;
		Constitution = 0;
		Intelligence = 0;
		Wisdom = 0;
		Charisma = 0;
		MoveSpeed = 30;
	}
}