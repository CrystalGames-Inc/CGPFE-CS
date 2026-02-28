using CGPFE.Domain.Combat.Action;
using CGPFE.Core.Enums;

namespace CGPFE.Domain.Combat.Action.Types;

public abstract class MoveAction(string name, bool attackOfOpportunity) : CombatAction(name, ActionType.Move, attackOfOpportunity)
{

}
