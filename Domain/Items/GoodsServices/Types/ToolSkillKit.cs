namespace CGPFE.Domain.Items.GoodsServices.Types;

public class ToolSkillKit(string name, int id, double cost, double? weight)
	: Good(name, id, cost, weight);