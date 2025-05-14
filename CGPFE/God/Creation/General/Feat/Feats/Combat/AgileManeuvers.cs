using CGPFE.Data.Constants;
using CGPFE.Management;
using Attribute = CGPFE.Data.Constants.Attribute;

namespace CGPFE.God.Creation.General.Feats.Feats.Combat;

public class AgileManeuvers() : Feat("Agile Maneuvers", FeatType.Combat) {

	public override bool CanAcquire() {
		return true;
	}

	public override void Benefits() {
		PlayerDataManager.Instance.Player.CombatInfo.CmbCalcBonus = Attribute.Dexterity;
	}
}