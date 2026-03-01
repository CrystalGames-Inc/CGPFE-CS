using CGPFE.Domain.Characters;
using CGPFE.Domain.Combat.Action.Types;

namespace Storage.CombatActions.StandardActions;

public class LightTorchWithTinderwig() : StandardAction("Light a torch with a tinderwig", true)
{
    protected override void Apply(Entity attacker, Entity target)
    {
        attacker.CombatInfo.ActionCount -= 1;
    }
}
