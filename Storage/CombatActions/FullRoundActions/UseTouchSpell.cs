using CGPFE.Domain.Characters;
using CGPFE.Domain.Combat.Action.Types;

namespace Storage.CombatActions.FullRoundActions;

public class UseTouchSpell() : FullRoundAction("Use a touch spell on up to 6 friends", true)
{
    protected override void Apply(Entity attacker, Entity target)
    {
        attacker.CombatInfo.ActionCount = 0;
    }
}
