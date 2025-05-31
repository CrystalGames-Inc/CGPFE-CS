using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class DeftHands(): Domain.Characters.Feats.Properties.Feat("Deft Hands") {
	public override bool CanAcquire() {
		return true;
	}

	public override void Benefits() {
		PlayerDataManager.Instance.Player.GetMatchingSkill("Disable Device").Bonus.SetMiscMod(
			PlayerDataManager.Instance.Player.GetMatchingSkill("Disable Device").Bonus.Ranks >= 10 ? 4 : 2);

		PlayerDataManager.Instance.Player.GetMatchingSkill("Sleight Of Hand").Bonus.SetMiscMod(
			PlayerDataManager.Instance.Player.GetMatchingSkill("Sleight Of Hand").Bonus.Ranks >= 10 ? 4 : 2);
	}
}