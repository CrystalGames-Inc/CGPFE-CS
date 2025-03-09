namespace CGPFE.Data.Models.Item.GoodsServices.Types;

public class Transport: Good {
	protected Transport(string name, int id, double cost, double? weight) : base(name, id, cost, weight) {
	}
}