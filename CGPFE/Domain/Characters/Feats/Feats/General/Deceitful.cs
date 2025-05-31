using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class Deceitful(): Domain.Characters.Feats.Properties.Feat("Deceitful") {
	public override bool CanAcquire() {
		return true;
	}

	public override void Benefits() {
		PlayerDataManager.Instance.Player.GetMatchingSkill("Bluff").Bonus.SetMiscMod(
			PlayerDataManager.Instance.Player.GetMatchingSkill("Bluff").Bonus.Ranks >= 10 ? 4 : 2);

		PlayerDataManager.Instance.Player.GetMatchingSkill("Disguise").Bonus.SetMiscMod(
			PlayerDataManager.Instance.Player.GetMatchingSkill("Disguise").Bonus.Ranks >= 10 ? 4 : 2);
	}
}