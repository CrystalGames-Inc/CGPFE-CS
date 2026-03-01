using CGPFE.Domain.Characters;
using CGPFE.Domain.Combat.Action.Types;

namespace Storage.CombatActions.MoveActions;

public class DrawWeapon() : MoveAction("Draw a weapon", false)
{
    protected override void Apply(Entity attacker, Entity target)
    {
        attacker.CombatInfo.ActionCount -= 1;
    }
}
