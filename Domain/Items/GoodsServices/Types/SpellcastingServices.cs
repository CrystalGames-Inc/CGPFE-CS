using Domain.Items.GoodsServices;

namespace Domain.Items.GoodsServices.Types;

public class SpellcastingServices(string name, int id, double cost) : Service(name, id, cost);
