using Domain.Items.Other;

namespace Domain.Items.GoodsServices.Types;

public class Clothing(string name, int id, double cost) : Outfit(name, id, cost);
