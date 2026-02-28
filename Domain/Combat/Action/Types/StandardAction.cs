using CGPFE.Domain.Combat.Action;
using CGPFE.Core.Enums;

namespace CGPFE.Domain.Combat.Action.Types;

public abstract class StandardAction(string name, bool attackOfOpportunity) : CombatAction(name, ActionType.Standard, attackOfOpportunity)
{

}
