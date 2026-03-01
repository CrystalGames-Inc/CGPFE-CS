using CGPFE.Core.Enums;
using CGPFE.Domain.Characters;
using CGPFE.Domain.Combat.Action;

namespace CGPFE.Domain.Combat.Action.Types;

public abstract class NoAction : CombatAction
{
    public string Name { get; set; }
    public bool AttackOfOpportunity { get; set; }

    public NoAction(string name, bool attackOfOpportunity) : base(name, ActionType.None, attackOfOpportunity)
    {
        Name = name;
        AttackOfOpportunity = attackOfOpportunity;
    }

    public new void Execute(Entity attacker, Entity target)
    {
        if (!CanExecute(attacker, target))
        {
            Console.Error.WriteLine($"Cannot execute {Name}.");
            return;
        }

        Apply(attacker, target);
    }

    protected new virtual bool CanExecute(Entity attacker, Entity target)
    {
        return true;
    }
}