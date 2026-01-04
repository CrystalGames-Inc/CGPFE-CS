namespace CGPFE.Domain.Items;

public class Item
{
    public string Name;
    public int Id;
    public double? Cost; //Price is in gp

    protected Item(string name, int id, double cost)
    {
        Name = name;
        Id = id;
        Cost = cost;
    }
}