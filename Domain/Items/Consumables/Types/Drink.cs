using Domain.Items.Consumables;

namespace Domain.Items.Consumables.Types;

public class Drink : Consumable
{
    public bool Alcoholic;
    public Drink(string name, int id, double cost, bool alcoholic) : base(name, id, cost) {
        Alcoholic = alcoholic;
    }

    public Drink(string name, int id, double cost, double weight, bool alcoholic) : base(name, id, cost, weight) {
        Alcoholic = alcoholic;
    }

    public override void Consume() {

    }
}
