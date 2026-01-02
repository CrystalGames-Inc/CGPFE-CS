using CGPFE.Core.Enums;

namespace CGPFE.Domain.Items.GoodsServices.Types;

public class Lodging: Service {

	public Quality Quality;
	
	public Lodging(string name, int id, double cost) : base(name, id, cost) {
	}

	public Lodging(string name, int id, double cost, Quality quality) : base(name, id, cost) {
		Quality = quality;
	}
}