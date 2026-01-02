using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class SelfSufficient(): Domain.Characters.Feats.Properties.Feat("Self-Sufficient") {
	public override bool CanAcquire() {
		return true;
	}

	public override void Benefits() {
		PlayerDataManager.Instance.Player.GetMatchingSkill("Heal").Bonus.SetMiscMod(
			PlayerDataManager.Instance.Player.GetMatchingSkill("Heal").Bonus.Ranks >= 10 ? 4 : 2);

		PlayerDataManager.Instance.Player.GetMatchingSkill("Survival").Bonus.SetMiscMod(
			PlayerDataManager.Instance.Player.GetMatchingSkill("Survival").Bonus.Ranks >= 10 ? 4 : 2);
	}
}