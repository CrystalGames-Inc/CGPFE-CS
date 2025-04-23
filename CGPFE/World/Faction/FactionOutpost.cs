using CGPFE.Data.Constants;

namespace CGPFE.World.Faction;

public class FactionOutpost(string name, OutpostType type) : Location(name, null, null) {
	public OutpostType OutpostType = type;
}