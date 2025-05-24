using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.General;

public class Toughness(): Feat("Toughness") {
	public override bool CanAcquire() {
		return true;
	}

	public override void Benefits() {
		PlayerDataManager.Instance.Player.PlayerInfo.MaxHealth += 3;
	}
}