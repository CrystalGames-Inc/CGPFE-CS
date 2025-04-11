using CGPFE.Data.Models.Item.Other;

namespace CGPFE.Data.Models.Item.GoodsServices.Types;

public class Food(string name, int id, double cost) : Consumable(name, id, cost);