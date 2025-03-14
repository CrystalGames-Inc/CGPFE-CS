namespace CGPFE.Data.Models.Item.Other;

public class Currency(string name, double copperValue, double silverValue, double goldValue, double platinumValue) {
	public string Name = name;
	public double CopperValue = copperValue;
	public double SilverValue = silverValue;
	public double GoldValue = goldValue;
	public double PlatinumValue = platinumValue;
}