namespace CGPFE.God.Creation.Player.Properties.Inventory;

public class InventoryItem(string name, int amount) {
	public string Name { get; set; } = name;
	public int Amount { get; set; } = amount;

	public InventoryItem(string name) : this(name, 1) {
	}
}