
using CGPFE.Domain.Items.GoodsServices;


namespace CGPFE.Domain.Items.GoodsServices.Types;

public class Transport(string name, int id, double cost, double? weight)
    : Good(name, id, cost, weight);
