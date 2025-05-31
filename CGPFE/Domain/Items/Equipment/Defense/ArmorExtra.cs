﻿namespace CGPFE.Domain.Items.Equipment.Defense;

public class ArmorExtra(
	string name,
	int id,
	double cost,
	int? armorCheckPenalty,
	int? arcSpellFailChance,
	int weightMod)
	: Domain.Items.Item(name, id, cost) {

	public int? ArmorCheckPenalty = armorCheckPenalty;
	public int? ArcSpellFailChance = arcSpellFailChance;
	public int WeightMod = weightMod;
}