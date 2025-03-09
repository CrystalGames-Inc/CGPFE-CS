using CGPFE.Data.Models.Item.Other;

namespace CGPFE.Data.Models.Item.GoodsServices.Types;

public class Drink: Consumable {
	protected Drink(string name, int id, double cost) : base(name, id, cost) {
	}
}