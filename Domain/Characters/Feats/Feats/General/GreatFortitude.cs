using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class GreatFortitude(): Domain.Characters.Feats.Properties.Feat("Great Fortitude") {
	public override bool CanAcquire() {
		return true;
	}

	public override void Benefits() {
		PlayerDataManager.Instance.Player.CombatInfo.Fortitude += 2;
	}
}