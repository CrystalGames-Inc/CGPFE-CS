using Attribute = CGPFE.Data.Constants.Attribute;

namespace CGPFE.God.Creation.General.Feats;

public class AbilityPrerequisite : IPrerequisite {
	public Attribute Ability { get; set; }
	public int Value { get; set; }

	public bool IsSatisfiedBy(Player.Player player) {
		return player.GetAbilityScore(Ability) >= Value;
	}
}

public class FeatPrerequisite : IPrerequisite {
	public string Name { get; set; }

	public bool IsSatisfiedBy(Player.Player player) {
		return player.HasFeat(Name);
	}
}

public class AndPrerequisite : IPrerequisite {
	public List<IPrerequisite> Prerequisites { get; set; } = [];

	public bool IsSatisfiedBy(Player.Player player) {
		return Prerequisites.All(p => p.IsSatisfiedBy(player));
	}
}