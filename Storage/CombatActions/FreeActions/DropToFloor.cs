using CGPFE.Domain.Characters;
using CGPFE.Domain.Combat.Action.Types;

namespace Storage.CombatActions.FreeActions;

public class DropToFloor() : FreeAction("Drop to the floor", false)
{
    protected override void Apply(Entity attacker, Entity target)
    {
        throw new NotImplementedException();
    }
}
