using Domain.Items;

namespace Domain.Items.GoodsServices;

public class Service : Item
{
    protected Service(string name, int id, double cost) : base(name, id, cost) {
    }
}
