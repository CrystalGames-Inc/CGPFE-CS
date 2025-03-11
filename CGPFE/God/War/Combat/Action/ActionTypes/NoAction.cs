using CGPFE.Data.Constants;

namespace CGPFE.God.War.Combat.Action.ActionTypes;

public class NoAction(string name, bool attackOfOpportunity) : CombatAction(name, ActionType.None, attackOfOpportunity) {
	
}