using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class IronWill(): Domain.Characters.Feats.Properties.Feat("Iron Will") {
	public override bool CanAcquire() {
		return true;
	}

	public override void Benefits() {
		PlayerDataManager.Instance.Player.CombatInfo.Will += 2;
	}
}