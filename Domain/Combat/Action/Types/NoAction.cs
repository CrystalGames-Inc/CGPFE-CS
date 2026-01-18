using CGPFE.Domain.Combat.Action;
using CGPFE.Core.Enums;

namespace CGPFE.Domain.Combat.Action.Types;

public class NoAction(string name, bool attackOfOpportunity) : CombatAction(name, ActionType.None, attackOfOpportunity)
{

}
