using CGPFE.Core.Enums;
using Domain.Combat.Action;

namespace Domain.Combat.Action.Types;

public class NoAction(string name, bool attackOfOpportunity) : CombatAction(name, ActionType.None, attackOfOpportunity) {
	
}