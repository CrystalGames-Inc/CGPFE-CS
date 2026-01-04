using CGPFE.Core.Enums;

namespace Domain.Combat.Action.Types;

public class SwiftAction(string name, bool attackOfOpportunity) : CombatAction(name, ActionType.Swift, attackOfOpportunity)
{

}