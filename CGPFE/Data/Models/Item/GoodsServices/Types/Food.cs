﻿using CGPFE.Data.Models.Item.Other;

namespace CGPFE.Data.Models.Item.GoodsServices.Types;

public class Food: Consumable {
	protected Food(string name, int id, double cost) : base(name, id, cost) {
	}
}