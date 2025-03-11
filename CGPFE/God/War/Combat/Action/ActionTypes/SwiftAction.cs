using CGPFE.Data.Constants;

namespace CGPFE.God.War.Combat.Action.ActionTypes;

public class SwiftAction(string name, bool attackOfOpportunity) : CombatAction(name, ActionType.Swift, attackOfOpportunity) {
	
}