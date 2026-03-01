using CGPFE.Domain.Characters;
using CGPFE.Domain.Combat.Action.Types;

namespace Storage.CombatActions.StandardActions;

public class LowerSpellResistance() : StandardAction("Lower Spell Resistance", false)
{
    protected override void Apply(Entity attacker, Entity target)
    {
        attacker.CombatInfo.ActionCount -= 1;
    }
}
