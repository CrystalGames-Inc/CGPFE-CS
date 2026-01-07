using Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Player;

namespace Storage.Feats.Combat;

public class IntimidatingProwess() : Feat("Intimidating Prowess", FeatType.Combat)
{
    public override bool CanAcquire(Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player player) {
        player.GetMatchingSkill("Intimidate").Bonus.MiscMod
            += player.AttributeModifiers.Strength.value;
    }
}