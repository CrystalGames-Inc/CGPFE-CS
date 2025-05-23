using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.General;

public class IronWill(): Feat("Iron Will") {
	public override bool CanAcquire() {
		return true;
	}

	public override void Benefits() {
		PlayerDataManager.Instance.Player.CombatInfo.Will += 2;
	}
}