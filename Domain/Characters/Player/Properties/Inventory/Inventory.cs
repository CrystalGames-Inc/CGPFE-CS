
namespace CGPFE.Domain.Characters.Player.Properties.Inventory;

public class Inventory {
	public List<InventoryItem>? Items { get; set; }
	public List<InventoryItem>? Weapons { get; set; }
	public List<InventoryItem>? Armors { get; set; }
	public List<InventoryItem>? Shields { get; set; }

	public Inventory() {
		Items = [];
		Weapons = [];
		Armors = [];
		Shields = [];
	}
}