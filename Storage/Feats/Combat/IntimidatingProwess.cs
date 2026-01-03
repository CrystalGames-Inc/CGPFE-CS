using CGPFE.Core.Enums;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class IntimidatingProwess(): Characters.Feats.Feat("Intimidating Prowess", FeatType.Combat) {
	public override bool CanAcquire() {
		return true;
	}

	public override void ApplyBenefits() {
        PlayerDataManager.Instance.Player.GetMatchingSkill("Intimidate").Bonus.MiscMod
			+= PlayerDataManager.Instance.Player.AttributeModifiers.Strength.value;
	}
}