using Domain.Items.GoodsServices;
using Core.Enums;

namespace Domain.Items.GoodsServices.Types;

public class Lodging : Service
{

    public Quality Quality;

    public Lodging(string name, int id, double cost) : base(name, id, cost) {
    }

    public Lodging(string name, int id, double cost, Quality quality) : base(name, id, cost) {
        Quality = quality;
    }
}
