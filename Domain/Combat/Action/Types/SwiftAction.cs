using CGPFE.Core.Enums;
using Domain.Combat.Action;

namespace Domain.Combat.Action.Types;

public class SwiftAction(string name, bool attackOfOpportunity) : CombatAction(name, ActionType.Swift, attackOfOpportunity) {
	
}