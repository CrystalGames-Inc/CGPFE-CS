using CGPFE.Data.Constants;

namespace CGPFE.God.War.Combat.Action.ActionTypes;

public class MoveAction(string name, bool attackOfOpportunity) : CombatAction(name, ActionType.Move, attackOfOpportunity) {
	
}