namespace CGPFE.Domain.Items.GoodsServices.Types;

public class SubstanceItem(string name, int id, double cost, double? weight)
	: Good(name, id, cost, weight);