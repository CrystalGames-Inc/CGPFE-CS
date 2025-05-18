using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.General;

public class Deceitful(): Feat("Deceitful") {
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