using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.General;

public class Persuasive(): Feat("Persuasive") {
	public override bool CanAcquire() {
		return true;
	}

	public override void Benefits() {
		PlayerDataManager.Instance.Player.GetMatchingSkill("Diplomacy").Bonus.SetMiscMod(
			PlayerDataManager.Instance.Player.GetMatchingSkill("Diplomacy").Bonus.Ranks >= 10 ? 4 : 2);

		PlayerDataManager.Instance.Player.GetMatchingSkill("Intimidate").Bonus.SetMiscMod(
			PlayerDataManager.Instance.Player.GetMatchingSkill("Intimidate").Bonus.Ranks >= 10 ? 4 : 2);
	}
}