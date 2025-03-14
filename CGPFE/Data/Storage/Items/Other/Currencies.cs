using CGPFE.Data.Models.Item.Other;

namespace CGPFE.Data.Storage.Items.Other;

public class Currencies {
	public static readonly Currency Copper = new Currency("Copper",1,0.1,0.01,0.001);
	public static readonly Currency Silver = new Currency("Silver",10,1,0.1,0.01);
	public static readonly Currency Gold = new Currency("Gold",100,10,1,0.1);
	public static readonly Currency Platinum = new Currency("Platinum",1000,100,10,1);
}