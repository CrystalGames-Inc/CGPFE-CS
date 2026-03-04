using CGPFE.Domain.Characters;
using CGPFE.Domain.Combat.Action.Types;

namespace Storage.CombatActions.FreeActions;

public class PrepareSpellComponents() : FreeAction("Prepare spell components to cast a spell", false)
{
    public override void Apply(Entity attacker, Entity target)
    {
        throw new NotImplementedException();
    }
}
