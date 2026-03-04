using CGPFE.Domain.Items.Equipment.Defense;
using CGPFE.Domain.Items.Equipment.Offense;

namespace Domain.Characters.Inventory;

public class Inventory
{
    public List<InventoryItem>? Items { get; set; }
    public List<InventoryItem>? Weapons { get; set; }
    public List<InventoryItem>? Armors { get; set; }
    public List<InventoryItem>? Shields { get; set; }
    public EquippedInventory? Equipped { get; set; }
    public Inventory() {
        Items = [];
        Weapons = [];
        Armors = [];
        Shields = [];
        Equipped = new();
    }
}
