using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.NPC;

namespace CGPFE.Domain.World.Factions;

public class FactionMember(Rank factionRank) {
	public NPC Member;
	public Rank FactionRank = factionRank;
}