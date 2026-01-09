
using CGPFE.Domain.Items.GoodsServices;


namespace CGPFE.Domain.Items.GoodsServices.Types;

public class MountGear(string name, int id, double cost, double? weight)
    : Good(name, id, cost, weight);
