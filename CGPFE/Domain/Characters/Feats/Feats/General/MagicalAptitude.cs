using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class MagicalAptitude(): Domain.Characters.Feats.Properties.Feat("Magical Aptitude") {
	public override bool CanAcquire() {
		return true;
	}

	public override void Benefits() {
		PlayerDataManager.Instance.Player.GetMatchingSkill("Spellcraft").Bonus.SetMiscMod(
			PlayerDataManager.Instance.Player.GetMatchingSkill("Spellcraft").Bonus.Ranks >= 10 ? 4 : 2);

		PlayerDataManager.Instance.Player.GetMatchingSkill("Use Magic Device").Bonus.SetMiscMod(
			PlayerDataManager.Instance.Player.GetMatchingSkill("Use Magic Device").Bonus.Ranks >= 10 ? 4 : 2);
	}
}