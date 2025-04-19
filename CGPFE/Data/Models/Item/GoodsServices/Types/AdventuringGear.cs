namespace CGPFE.Data.Models.Item.GoodsServices.Types;

public class AdventuringGear : Good {
	public AdventuringGear(string name, int id, double cost, double? weight) : base(name, id, cost, weight) {
		
	}

	public AdventuringGear(string name, int id, double cost) : base(name, id, cost) {
		
	}
}