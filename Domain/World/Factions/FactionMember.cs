using Domain.Characters.NPC;
using Core.Enums;

namespace Domain.World.Factions;

public class FactionMember(Rank factionRank)
{
    public NPC Member;
    public Rank FactionRank = factionRank;
}
