using CGPFE.Data.Constants;

namespace CGPFE.God.War.Combat.Action.ActionTypes;

public class StandardAction(string name, bool attackOfOpportunity) : CombatAction(name, ActionType.Standard, attackOfOpportunity) {
	
}