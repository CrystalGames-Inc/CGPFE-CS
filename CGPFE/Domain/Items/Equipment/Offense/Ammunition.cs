﻿namespace CGPFE.Domain.Items.Equipment.Offense;

public class Ammunition(string name, int id, double cost, int amount, int weight)
	: Domain.Items.Item(name, id, cost) {

	public int Amount = amount;
	public int Weight = weight;
}