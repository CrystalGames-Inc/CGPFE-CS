using CGPFE.Core.Enums;

namespace CGPFE.Domain.Combat.Actions.Base.Types;

public class MoveAction(string name, bool attackOfOpportunity) : CombatAction(name, ActionType.Move, attackOfOpportunity) {
	
}