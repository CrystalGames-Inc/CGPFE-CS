using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.General;

public class Alertness(): Feat("Alertness") {
	public override bool CanAcquire() {
		return true;
	}

	public override void Benefits() {
		PlayerDataManager.Instance.Player.GetMatchingSkill("Perception").Bonus.SetMiscMod(
			PlayerDataManager.Instance.Player.GetMatchingSkill("Perception").Bonus.Ranks >= 10 ? 4 : 2);

		PlayerDataManager.Instance.Player.GetMatchingSkill("Sense Motive").Bonus.SetMiscMod(
			PlayerDataManager.Instance.Player.GetMatchingSkill("Sense Motive").Bonus.Ranks >= 10 ? 4 : 2);
	}
}