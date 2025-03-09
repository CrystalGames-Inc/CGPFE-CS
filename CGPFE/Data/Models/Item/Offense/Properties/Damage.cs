namespace CGPFE.Data.Models.Item.Offense.Properties;

public abstract class Damage(int die, int amount) {
	public int Die = die;
	public int Amount = amount;

	protected Damage(int die) : this(die, 1) {
	}
}