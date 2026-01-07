namespace Domain.Characters.Player.Properties.Inventory;

public class InventoryItem(string name, int amount = 1)
{
    public string Name { get; set; } = name;
    public int Amount { get; set; } = amount;
}