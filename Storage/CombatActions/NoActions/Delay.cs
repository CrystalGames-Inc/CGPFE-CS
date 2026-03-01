using CGPFE.Domain.Characters;
using CGPFE.Domain.Combat.Action.Types;

namespace Storage.CombatActions.NoActions;

public class Delay() : NoAction("Delay", false)
{
    protected override void Apply(Entity attacker, Entity target)
    {
        throw new NotImplementedException();
    }
}
