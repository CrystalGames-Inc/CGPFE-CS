using CGPFE.Domain.Characters.NPC;
using CGPFE.Core.Enums;

namespace CGPFE.Domain.World.Factions;

public class FactionMember(Rank factionRank)
{
    public NPC Member;
    public Rank FactionRank = factionRank;
}
