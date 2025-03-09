﻿using CGPFE.Data.Constants;

namespace CGPFE.Data.Models.Item.Defense;

public class Armor(
	string name,
	int id,
	double cost,
	Weight type,
	int armorBonus,
	int maxDexBonus,
	int armorCheckPenalty,
	int arcCheckFailChance,
	int[] speeds,
	int weight)
	: Item(name, id, cost) {

	public Weight Type = type;
	public int ArmorBonus = armorBonus;
	public int MaxDexBonus = maxDexBonus;
	public int ArmorCheckPenalty = armorCheckPenalty;
	public int ArcCheckFailChance = arcCheckFailChance;
	public int[] Speeds = speeds;
	public int Weight = weight;
}