using CGPFE.Domain.Combat.Action;
using CGPFE.Core.Enums;

namespace CGPFE.Domain.Combat.Action.Types;

public abstract class FreeAction(string name, bool attackOfOpportunity) : CombatAction(name, ActionType.Free, attackOfOpportunity)
{
}
