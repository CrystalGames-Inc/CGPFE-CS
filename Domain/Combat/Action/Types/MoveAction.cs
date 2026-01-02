using CGPFE.Core.Enums;
using Domain.Combat.Action;

namespace Domain.Combat.Action.Types;

public class MoveAction(string name, bool attackOfOpportunity) : CombatAction(name, ActionType.Move, attackOfOpportunity) {
	
}