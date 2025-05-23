using CGPFE.Data.Constants;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class IntimidatingProwess(): Feat("Intimidating Prowess", FeatType.Combat) {
	public override bool CanAcquire() {
		return true;
	}

	public override void Benefits() {
		PlayerDataManager.Instance.Player.GetMatchingSkill("Intimidate").Bonus.MiscMod += PlayerDataManager.Instance.Player.AttributeModifiers.Strength;
	}
}