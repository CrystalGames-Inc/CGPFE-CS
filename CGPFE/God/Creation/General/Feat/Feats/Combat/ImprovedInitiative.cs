using CGPFE.Data.Constants;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class ImprovedInitiative(): Feat("Improved Initiative", FeatType.Combat) {
	public override bool CanAcquire() {
		return true;
	}

	public override void Benefits() {
		PlayerDataManager.Instance.Player.CombatInfo.InitMod += 4;
	}
}