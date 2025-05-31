using CGPFE.Core.Enums;

namespace CGPFE.Domain.Combat.Actions.Base.Types;

public class FullRoundAction(string name, bool attackOfOpportunity) : CombatAction(name, ActionType.FullRound, attackOfOpportunity) {
	
}