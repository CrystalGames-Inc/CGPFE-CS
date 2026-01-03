using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Player;
using Attribute = CGPFE.Core.Enums.Attribute;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class AgileManeuvers() : Characters.Feats.Feat("Agile Maneuvers", FeatType.Combat) {

	public override bool CanAcquire(Domain.Characters.Player.Player player) {
		return true;
	}

	public override void ApplyBenefits(ref Player.Player player) {
		player.CombatInfo.CmbCalcBonus = Attribute.Dexterity;
	}
}