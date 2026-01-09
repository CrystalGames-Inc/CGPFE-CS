using CGPFE.Domain.Items.Consumables;

namespace CGPFE.Domain.Items.Consumables.Types;

public class Food : Consumable
{
    public Food(string name, int id, double cost) : base(name, id, cost) {
    }

    public Food(string name, int id, double cost, double weight) : base(name, id, cost, weight) {
    }

    public override void Consume() {

    }
}
