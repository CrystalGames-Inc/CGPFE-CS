using CGPFE.Domain.Characters;
using CGPFE.Domain.Combat.Action.Types;

namespace Storage.CombatActions.FullRoundActions;

public class LoadHeavyRepeatingCrossbow() : FullRoundAction("Load a heavy or repeating crossbow", true)
{
    public override void Apply(Entity attacker, Entity target)
    {
        attacker.CombatInfo.ActionCount = 0;
    }
}
