using CGPFE.Core.Enums;

namespace CGPFE.Domain.Combat.Actions.Base.Types;

public class StandardAction(string name, bool attackOfOpportunity) : CombatAction(name, ActionType.Standard, attackOfOpportunity) {
	
}