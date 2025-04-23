namespace CGPFE.Data.Models.Item.GoodsServices;

public class Good: Item {

	public double? Weight;

	protected Good(string name, int id, double cost) : base(name, id, cost) {
	}
	
	protected Good(string name, int id, double cost, double? weight) : base(name, id, cost) {
		Weight = weight;
	}
}