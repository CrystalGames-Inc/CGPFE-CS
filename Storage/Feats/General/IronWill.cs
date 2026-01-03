using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class IronWill(): Characters.Feats.Feat("Iron Will") {
	public override bool CanAcquire() {
		return true;
	}

	public override void ApplyBenefits() {
		PlayerDataManager.Instance.Player.CombatInfo.Will += 2;
	}
}