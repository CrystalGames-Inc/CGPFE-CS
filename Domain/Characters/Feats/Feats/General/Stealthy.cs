using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class Stealthy(): Domain.Characters.Feats.Properties.Feat("Stealthy") {
	public override bool CanAcquire() {
		return true;
	}

	public override void Benefits() {
		PlayerDataManager.Instance.Player.GetMatchingSkill("Escape Artist").Bonus.SetMiscMod(
			PlayerDataManager.Instance.Player.GetMatchingSkill("Escape Artist").Bonus.Ranks >= 10 ? 4 : 2);

		PlayerDataManager.Instance.Player.GetMatchingSkill("Stealth").Bonus.SetMiscMod(
			PlayerDataManager.Instance.Player.GetMatchingSkill("Stealth").Bonus.Ranks >= 10 ? 4 : 2);
	}
}