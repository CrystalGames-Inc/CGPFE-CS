using CGPFE.Domain.Characters;
using CGPFE.Domain.Combat.Action.Types;

namespace Storage.CombatActions.FullRoundActions;

public class LockUnlockGauntletWeapon() : FullRoundAction("Lock or unlock weapon in locked gauntlet", true)
{
    protected override void Apply(Entity attacker, Entity target)
    {
        attacker.CombatInfo.ActionCount = 0;
    }
}
