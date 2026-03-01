using CGPFE.Domain.Characters;
using CGPFE.Domain.Combat.Action.Types;

namespace Storage.CombatActions.FreeActions;

public class DropItem() : FreeAction("Drop An Item", false)
{
    protected override void Apply(Entity attacker, Entity target)
    {
        throw new NotImplementedException();
    }
}
