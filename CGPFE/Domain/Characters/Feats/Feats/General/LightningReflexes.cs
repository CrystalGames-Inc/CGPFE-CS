using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class LightningReflexes(): Domain.Characters.Feats.Properties.Feat("Lightning Reflexes") {
	public override bool CanAcquire() {
		return true;
	}

	public override void Benefits() {
		PlayerDataManager.Instance.Player.CombatInfo.Reflex += 2;
	}
}