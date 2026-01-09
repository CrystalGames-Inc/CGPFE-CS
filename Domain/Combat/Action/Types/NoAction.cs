using Domain.Combat.Action;
using Core.Enums;

namespace Domain.Combat.Action.Types;

public class NoAction(string name, bool attackOfOpportunity) : CombatAction(name, ActionType.None, attackOfOpportunity)
{

}
