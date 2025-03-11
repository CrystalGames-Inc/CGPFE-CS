using CGPFE.Data.Constants;

namespace CGPFE.God.War.Combat.Action.ActionTypes;

public class FullRoundAction(string name, bool attackOfOpportunity) : CombatAction(name, ActionType.FullRound, attackOfOpportunity) {
	
}