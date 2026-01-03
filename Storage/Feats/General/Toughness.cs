using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class Toughness(): Characters.Feats.Feat("Toughness") {
	public override bool CanAcquire() {
		return true;
	}

	public override void ApplyBenefits() {
		PlayerDataManager.Instance.Player.PlayerInfo.MaxHealth += 3;
	}
}