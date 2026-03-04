using CGPFE.Domain.Characters;
using CGPFE.Domain.Combat.Action.Types;

namespace Storage.CombatActions.FreeActions;

public class CeaseSpellConcentration() : FreeAction("Cease concentration on spell", false)
{
    public override void Apply(Entity attacker, Entity target)
    {
        throw new NotImplementedException();
    }
}
