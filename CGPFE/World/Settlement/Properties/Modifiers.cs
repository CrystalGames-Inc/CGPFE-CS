namespace CGPFE.World.Settlement.Properties;

public class Modifiers(Quality[] qualities, Disadvantage[] disadvantages) {
	public int Corruption = 0;
	public int Crime = 0;
	public int Economy = 0;
	public int Law = 0;
	public int Lore = 0;
	public int Society = 0;

	public Quality[] Qualities = qualities;
	public readonly Disadvantage[] Disadvantages = disadvantages;
}