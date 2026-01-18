using CGPFE.Domain.Combat.Action;
using CGPFE.Core.Enums;

namespace CGPFE.Domain.Combat.Action.Types;

public class ImmediateAction(string name, bool attackOfOpportunity) : CombatAction(name, ActionType.Immediate, attackOfOpportunity)
{

}
