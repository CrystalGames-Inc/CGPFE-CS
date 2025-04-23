using CGPFE.Data.Models.Item.Other;

namespace CGPFE.Data.Models.Item.GoodsServices.Types;

public class Drink: Consumable {
	public bool Alcoholic;
	public Drink(string name, int id, double cost, bool alcoholic) : base(name, id, cost) {
		Alcoholic = alcoholic;
	}

	public Drink(string name, int id, double cost, double weight, bool alcoholic) : base(name, id, cost, weight) {
		Alcoholic = alcoholic;
	}
}