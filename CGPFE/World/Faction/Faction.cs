using CGPFE.Data.Constants;

namespace CGPFE.World.Faction;

public class Faction(string name, FactionType type) {
	public string Name = name;
	public FactionType Type = type;

	private List<FactionMember>? Members { get; set; }

	public void AddMember(FactionMember member) {
		Members ??= new List<FactionMember>();
		Members.Add(member);
	}

	public void RemoveMember(FactionMember member) {
		Members?.Remove(member);
	}

	public FactionMember? GetMember(FactionMember member) {
		if(Members != null && Members.Contains(member))
			return Members[Members.IndexOf(member)];
		Console.WriteLine("Member does not exist in the faction");
		return null;
	}

	public void ChangeMemberRank(FactionMember member, Rank rank) {
		if(Members != null && Members.Contains(member))
			Members[Members.IndexOf(member)].FactionRank = rank;
		else 
			Console.WriteLine("Member does not exist in the faction");
	}
}