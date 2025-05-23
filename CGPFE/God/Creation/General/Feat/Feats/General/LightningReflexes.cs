using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.General;

public class LightningReflexes(): Feat("Lightning Reflexes") {
	public override bool CanAcquire() {
		return true;
	}

	public override void Benefits() {
		PlayerDataManager.Instance.Player.CombatInfo.Reflex += 2;
	}
}