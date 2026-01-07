using Core.Enums;
using Domain.Characters.NPC;

namespace Domain.World.Factions;

public class FactionMember(Rank factionRank)
{
    public NPC Member;
    public Rank FactionRank = factionRank;
}