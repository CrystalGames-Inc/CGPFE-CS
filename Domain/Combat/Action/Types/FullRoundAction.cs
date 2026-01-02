using CGPFE.Core.Enums;
using Domain.Combat.Action;

namespace Domain.Combat.Action.Types;

public class FullRoundAction(string name, bool attackOfOpportunity) : CombatAction(name, ActionType.FullRound, attackOfOpportunity) {
	
}