using CGPFE.Core.Enums;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class IntimidatingProwess(): Domain.Characters.Feats.Properties.Feat("Intimidating Prowess", FeatType.Combat) {
	public override bool CanAcquire() {
		return true;
	}

	public override void Benefits() {
        PlayerDataManager.Instance.Player.GetMatchingSkill("Intimidate").Bonus.MiscMod
			+= PlayerDataManager.Instance.Player.AttributeModifiers.Strength.value;
	}
}