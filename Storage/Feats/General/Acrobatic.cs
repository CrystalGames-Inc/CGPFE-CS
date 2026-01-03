using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class Acrobatic() : Characters.Feats.Feat("Acrobatic") {
	public override bool CanAcquire() {
		return true;
	}

	public override void ApplyBenefits() {
		PlayerDataManager.Instance.Player.GetMatchingSkill("Acrobatics").Bonus.SetMiscMod(
			PlayerDataManager.Instance.Player.GetMatchingSkill("Acrobatics").Bonus.Ranks >= 10 ? 4 : 2);

		PlayerDataManager.Instance.Player.GetMatchingSkill("Fly").Bonus.SetMiscMod(
			PlayerDataManager.Instance.Player.GetMatchingSkill("Fly").Bonus.Ranks >= 10 ? 4 : 2);
	}
}