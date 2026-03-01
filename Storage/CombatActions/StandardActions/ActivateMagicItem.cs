using CGPFE.Domain.Characters;
using CGPFE.Domain.Combat.Action.Types;

namespace Storage.CombatActions.StandardActions;

public class ActivateMagicItem() : StandardAction("Activate a magic item", false)
{
    protected override void Apply(Entity attacker, Entity target)
    {
        attacker.CombatInfo.ActionCount -= 1;
    }
}
