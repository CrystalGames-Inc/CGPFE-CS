namespace CGPFE.World.Settlement.Properties;

public abstract class Modifiers(Quality[] qualities, Disadvantage[] disadvantages) {
	public int Corruption { get; set; } = 0;
	public int Crime { get; set; } = 0;
	public int Economy { get; set; } = 0;
	public int Law { get; set; } = 0;
	public int Lore { get; set; } = 0;
	public int Society { get; set; } = 0;

	public Quality[] Qualities = qualities;
	public readonly Disadvantage[] Disadvantages = disadvantages;
}