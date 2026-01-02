using CGPFE.Core.Enums;

namespace CGPFE.Domain.Combat.Actions.Base.Types;

public class NoAction(string name, bool attackOfOpportunity) : CombatAction(name, ActionType.None, attackOfOpportunity) {
	
}