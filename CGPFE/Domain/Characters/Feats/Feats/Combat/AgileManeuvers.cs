using CGPFE.Core.Enums;
using CGPFE.Management;
using Attribute = CGPFE.Core.Enums.Attribute;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class AgileManeuvers() : Domain.Characters.Feats.Properties.Feat("Agile Maneuvers", FeatType.Combat) {

	public override bool CanAcquire() {
		return true;
	}

	public override void Benefits() {
		PlayerDataManager.Instance.Player.CombatInfo.CmbCalcBonus = Attribute.Dexterity;
	}
}