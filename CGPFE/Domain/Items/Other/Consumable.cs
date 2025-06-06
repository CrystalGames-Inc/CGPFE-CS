﻿namespace CGPFE.Domain.Items.Other;

public class Consumable: Domain.Items.Item {

	public double? Weight;

	protected Consumable(string name, int id, double cost) : base(name, id, cost) {
	}

	protected Consumable(string name, int id, double cost, double weight) : base(name, id, cost) {
		Weight = weight;
	}
}