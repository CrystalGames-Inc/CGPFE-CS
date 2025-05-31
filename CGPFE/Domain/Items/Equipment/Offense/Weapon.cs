﻿using CGPFE.Domain.Items.Equipment.Offense.Properties;
using Type = CGPFE.Domain.Items.Equipment.Offense.Properties.Type;

namespace CGPFE.Domain.Items.Equipment.Offense;

public class Weapon(string name, int id, int maxCapacity, double? cost, Damage? damageS, Damage? damageM, Critical? critical, int? range, double? weight, Type[]? type, Special[]? special)
	: Domain.Items.Item(name, id, (double)cost!) {
	
	public int MaxCapacity = maxCapacity;
	public Damage? DamageS = damageS;
	public Damage? DamageM = damageM;
	public Critical? Critical = critical;
	public int? Range = range;
	public double? Weight = weight;
	public Type[]? Type = type;
	public Special[]? Special = special;
}