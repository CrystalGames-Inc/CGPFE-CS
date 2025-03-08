namespace CGPFE.Data.Models.Item.Weapon;

public abstract class Ammunition(string name, int id, int amount, double cost, double weight)
	: Item(name, id, cost) {
	public int Amount = amount;
	public double Weight = weight;
}