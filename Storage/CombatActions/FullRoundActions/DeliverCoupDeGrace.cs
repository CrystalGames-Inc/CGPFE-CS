using CGPFE.Domain.Characters;
using CGPFE.Domain.Combat.Action.Types;

namespace Storage.CombatActions.FullRoundActions;

public class DeliverCoupDeGrace() : FullRoundAction("Deliver Coup De Grace", true)
{
    protected override void Apply(Entity attacker, Entity target)
    {
        attacker.CombatInfo.ActionCount = 0;
    }
}
