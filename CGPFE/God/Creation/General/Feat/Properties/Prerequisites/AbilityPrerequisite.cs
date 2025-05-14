using Attribute = CGPFE.Data.Constants.Attribute;

namespace CGPFE.God.Creation.General.Feats.Prerequisites;

public class AbilityPrerequisite : IPrerequisite {
	public Attribute Ability { get; set; }
	public int Value { get; set; }

	public bool IsSatisfiedBy(Player.Player player) {
		return player.GetAbilityScore(Ability) >= Value;
	}
}