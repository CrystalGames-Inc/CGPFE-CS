using CGPFE.Data.Constants;

namespace CGPFE.World.Settlement.Properties;

public abstract class Info {
	public string Name;
	public string Nickname;
	
	public readonly Type Type;
	public Alignment Alignment;
	public int Danger;
	
	public Government Government { get; set; }
	public int Population { get; set; }

	protected Info(string name, string nickname, Type type, Alignment alignment, int danger, Government government, int population) {
		this.Name = name;
		this.Nickname = nickname;
		this.Type = type;
		this.Alignment = alignment;
		this.Danger = danger;
		this.Government = government;
		this.Population = population;
	}
}