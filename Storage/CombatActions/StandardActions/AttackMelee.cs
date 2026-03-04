using CGPFE.Core.Utilities;
using CGPFE.Domain.Characters;
using CGPFE.Domain.Combat.Action.Types;
using CGPFE.Domain.Items.Equipment.Offense;
using CGPFE.Storage.Items.Equipment.Offense;

namespace Storage.CombatActions.StandardActions;

public class AttackMelee(string weaponName = "Unarmed Strike") : StandardAction("Attack (melee)", false)
{
    public override void Apply(Entity attacker, Entity target)
    {
        Weapon? weapon = null;
        if (attacker.Inventory.Weapons.Count == 0)
        {
            if(!PromptHelper.YesNoPrompt("You have no weapons to attack with! Do you want to attack unarmed?", false))
            {
                Console.WriteLine("Action cancelled.");
                return;
            }
        }
        else if (attacker.Inventory.Equipped.Weapon == string.Empty)
        {
            if(!PromptHelper.YesNoPrompt("You have no weapon equipped! Do you want to attack unarmed?", false))
            {
                Console.WriteLine("Action cancelled.");
                return;
            }
        }
        else
        {
            weaponName = attacker.Inventory.Equipped.Weapon;
        }
        weapon = StorageNavigator.GetMatchingT(weaponName, Weapons.weapons);
        attacker.CombatInfo.ActionCount -= 1;
        target.CombatInfo.Health -= weapon.RollMDamage(target);
    }
}