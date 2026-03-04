using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Player;
using CGPFE.Core.Enums;
using CGPFE.Storage.Skills;

namespace Storage.Feats.Combat;

public class IntimidatingProwess() : Feat("Intimidating Prowess", FeatType.Combat)
{
    public override bool CanAcquire(Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player player) {
        player.GetMatchingSkill("Intimidate", [.. Skills.skills]).Bonus.MiscMod
            += player.Attributes.Strength.Modifier;
    }
}
