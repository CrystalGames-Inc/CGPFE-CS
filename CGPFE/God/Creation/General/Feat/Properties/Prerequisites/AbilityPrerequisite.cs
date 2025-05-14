using Attribute = CGPFE.Data.Constants.Attribute;

namespace CGPFE.God.Creation.General.Feats.Prerequisites;

public class AbilityPrerequisite(Attribute ability, int value) : IPrerequisite {
	public Attribute Ability { get; init; } = ability;
	public int Value { get; init; } = value;

	public bool IsSatisfiedBy(Player.Player player) {
		return player.GetAbilityScore(Ability) >= Value;
	}
}