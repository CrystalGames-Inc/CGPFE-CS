using Domain.World.Factions;
using Domain.World.Geography;
using Core.Enums;

namespace Domain.World.Factions;

public class Faction(string name, FactionType type, Location operationBase)
{
    public string Name = name;
    public FactionType Type = type;
    public Location OperationBase = operationBase;

    private List<Location>? Outposts { get; set; }
    private List<FactionMember>? Members { get; set; }

    #region Outposts

    public void AddOutpost(FactionOutpost location) {
        Outposts ??= [];
        Outposts.Add(location);
    }

    public void RemoveOutpost(FactionOutpost location) {
        Outposts?.Remove(location);
    }

    public Location? GetOutpost(FactionOutpost location) {
        if (Outposts != null && Outposts.Contains(location))
            return location;
        Console.WriteLine("Bureau does not exist for the faction");
        return null;
    }

    #endregion

    #region Members

    public void AddMember(FactionMember member) {
        Members ??= [];
        Members.Add(member);
    }

    public void RemoveMember(FactionMember member) {
        Members?.Remove(member);
    }

    public FactionMember? GetMember(FactionMember member) {
        if (Members != null && Members.Contains(member))
            return Members[Members.IndexOf(member)];
        Console.WriteLine("Member does not exist in the faction");
        return null;
    }

    public void ChangeMemberRank(FactionMember member, Rank rank) {
        if (Members != null && Members.Contains(member))
            Members[Members.IndexOf(member)].FactionRank = rank;
        else
            Console.WriteLine("Member does not exist in the faction");
    }

    #endregion
}
