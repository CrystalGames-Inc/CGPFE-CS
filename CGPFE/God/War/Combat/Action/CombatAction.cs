﻿using CGPFE.Data.Constants;

namespace CGPFE.God.War.Combat.Action;

public class CombatAction(string name, ActionType type, bool attackOfOpportunity) {
	public readonly string Name = name;
	public readonly ActionType Type = type;
	public readonly bool AttackOfOpportunity = attackOfOpportunity;
}