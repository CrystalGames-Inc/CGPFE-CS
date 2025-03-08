using CGPFE.Data.Constants;

namespace CGPFE.Data.Models.Item.GoodsServices.Types;

public class Lodging: Service {

	public Quality Quality;
	
	protected Lodging(string name, int id, double cost) : base(name, id, cost) {
	}

	protected Lodging(string name, int id, double cost, Quality quality) : base(name, id, cost) {
		Quality = quality;
	}
}