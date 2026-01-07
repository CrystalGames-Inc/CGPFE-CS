using Core.Enums;

namespace Domain.Combat.Action.Types;

public class ImmediateAction(string name, bool attackOfOpportunity) : CombatAction(name, ActionType.Immediate, attackOfOpportunity)
{

}