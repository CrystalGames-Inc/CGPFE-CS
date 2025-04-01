using CGPFE.Data.Constants;
using CGPFE.God.Creation.NPC;

namespace CGPFE.World.Faction;

public class FactionMember(Rank factionRank) {
	public NPC Member;
	public Rank FactionRank = factionRank;
}