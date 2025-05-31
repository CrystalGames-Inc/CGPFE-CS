using CGPFE.Domain.Items.Other;

namespace CGPFE.Domain.Items.GoodsServices.Types;

public class Food: Consumable {
	public Food(string name, int id, double cost) : base(name, id, cost) {
	}

	public Food(string name, int id, double cost, double weight) : base(name, id, cost, weight) {
	}
}