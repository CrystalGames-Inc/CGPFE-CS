using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.General;

public class GreatFortitude(): Feat("Great Fortitude") {
	public override bool CanAcquire() {
		return true;
	}

	public override void Benefits() {
		PlayerDataManager.Instance.Player.CombatInfo.Fortitude += 2;
	}
}