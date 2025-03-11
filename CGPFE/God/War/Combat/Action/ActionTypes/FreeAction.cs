using CGPFE.Data.Constants;

namespace CGPFE.God.War.Combat.Action.ActionTypes;

public class FreeAction(string name, bool attackOfOpportunity) : CombatAction(name, ActionType.Free, attackOfOpportunity) {
}