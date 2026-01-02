using CGPFE.Core.Enums;
using Domain.Combat.Action;

namespace Domain.Combat.Action.Types;

public class FreeAction(string name, bool attackOfOpportunity) : CombatAction(name, ActionType.Free, attackOfOpportunity) {
}