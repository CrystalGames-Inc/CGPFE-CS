using CGPFE.Core.Enums;
using Domain.Combat.Action;

namespace Domain.Combat.Action.Types;

public class StandardAction(string name, bool attackOfOpportunity) : CombatAction(name, ActionType.Standard, attackOfOpportunity) {
	
}