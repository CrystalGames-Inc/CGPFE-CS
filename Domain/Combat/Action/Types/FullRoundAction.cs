using Domain.Combat.Action;
using Core.Enums;

namespace Domain.Combat.Action.Types;

public class FullRoundAction(string name, bool attackOfOpportunity) : CombatAction(name, ActionType.FullRound, attackOfOpportunity)
{

}
