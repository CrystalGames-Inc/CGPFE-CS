namespace CGPFE.Data.Models.Item.GoodsServices.Types;

public class SubstanceItem(string name, int id, double cost, double? weight)
	: Good(name, id, cost, weight);