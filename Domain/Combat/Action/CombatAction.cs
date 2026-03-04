using CGPFE.Core.Enums;
using CGPFE.Domain.Characters;

namespace CGPFE.Domain.Combat.Action;

public abstract class CombatAction
{
    public string Name { get; }
    public ActionType Type { get; }
    public bool AttackOfOpportunity { get; }

    public CombatAction(string name, ActionType type, bool attackOfOpportunity)
    {
        Name = name;
        Type = type;
        AttackOfOpportunity = attackOfOpportunity;
    }

    public void Execute(Entity attacker,  Entity target)
    {
        if(!CanExecute(attacker, target))
        {
            Console.Error.WriteLine($"Cannot execute {Name}.");
            return;
        }

        Apply(attacker, target);
    }

    protected virtual bool CanExecute(Entity attacker, Entity target)
    {
        return true;
    }

    public abstract void Apply(Entity attacker, Entity target);
}