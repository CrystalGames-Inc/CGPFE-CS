using CGPFE.Data.Constants;

namespace CGPFE.God.War.Combat.Action.ActionTypes;

public class ImmediateAction(string name, bool attackOfOpportunity) : CombatAction(name, ActionType.Immediate, attackOfOpportunity) {
	
}