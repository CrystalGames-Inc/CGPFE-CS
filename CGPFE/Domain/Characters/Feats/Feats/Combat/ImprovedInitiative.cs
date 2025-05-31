using CGPFE.Core.Enums;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ImprovedInitiative(): Domain.Characters.Feats.Properties.Feat("Improved Initiative", FeatType.Combat) {
	public override bool CanAcquire() {
		return true;
	}

	public override void Benefits() {
		PlayerDataManager.Instance.Player.CombatInfo.InitMod += 4;
	}
}