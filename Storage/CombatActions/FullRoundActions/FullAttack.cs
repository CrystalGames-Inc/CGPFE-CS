using CGPFE.Domain.Characters;
using CGPFE.Domain.Combat.Action.Types;

namespace Storage.CombatActions.FullRoundActions;

public class FullAttack() : FullRoundAction("Full attack", false)
{
    protected override void Apply(Entity attacker, Entity target)
    {
        attacker.CombatInfo.ActionCount = 0;
    }
}
