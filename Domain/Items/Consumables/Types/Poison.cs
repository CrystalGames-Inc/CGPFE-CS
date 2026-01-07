namespace Domain.Items.Consumables.Types;

public class Poison : Consumable
{
    protected Poison(string name, int id, double cost) : base(name, id, cost) {
    }

    protected Poison(string name, int id, double cost, double weight) : base(name, id, cost, weight) {
    }

    public override void Consume() { }
}