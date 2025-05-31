using CGPFE.Core.Enums;

namespace CGPFE.Domain.Combat.Actions.Base.Types;

public class SwiftAction(string name, bool attackOfOpportunity) : CombatAction(name, ActionType.Swift, attackOfOpportunity) {
	
}