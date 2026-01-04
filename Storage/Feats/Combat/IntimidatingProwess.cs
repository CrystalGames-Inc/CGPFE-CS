using CGPFE.Core.Enums;
using Domain.Characters.Feat;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class IntimidatingProwess() : Feat("Intimidating Prowess", FeatType.Combat)
{
    public override bool CanAcquire(Player.Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player.Player player) {
        player.GetMatchingSkill("Intimidate").Bonus.MiscMod
            += player.AttributeModifiers.Strength.value;
    }
}