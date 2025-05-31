using CGPFE.Core.Enums;
using CGPFE.Domain.World.Geography;

namespace CGPFE.Domain.World.Factions;

public class FactionOutpost(string name, OutpostType type) : Location(name, null, null) {
	public OutpostType OutpostType = type;
}