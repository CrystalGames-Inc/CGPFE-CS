using CGPFE.Domain.Characters;
using CGPFE.Domain.Combat.Action.Types;

namespace Storage.CombatActions.SwiftActions;

public class CastQuickenedSpell() : SwiftAction("Cast a quickened spell", false)
{
    protected override void Apply(Entity attacker, Entity target)
    {
        attacker.CombatInfo.SwiftActionCount -= 1;
    }
}
