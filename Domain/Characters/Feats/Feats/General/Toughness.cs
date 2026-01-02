using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class Toughness(): Domain.Characters.Feats.Properties.Feat("Toughness") {
	public override bool CanAcquire() {
		return true;
	}

	public override void Benefits() {
		PlayerDataManager.Instance.Player.PlayerInfo.MaxHealth += 3;
	}
}