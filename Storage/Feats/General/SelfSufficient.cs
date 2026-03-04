using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Player;
using CGPFE.Storage.Skills;

namespace Storage.Feats.General;

public class SelfSufficient() : Feat("Self-Sufficient")
{
    public override bool CanAcquire(Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player player) {
        player.GetMatchingSkill("Heal", [..Skills.skills]).Bonus.
            ChangeMiscMod(player.GetMatchingSkill("Heal", [..Skills.skills]).Bonus.Ranks >= 10 ? 4 : 2);
        player.GetMatchingSkill("Survival", [.. Skills.skills]).Bonus.
            ChangeMiscMod(player.GetMatchingSkill("Survival", [.. Skills.skills]).Bonus.Ranks >= 10 ? 4 : 2);
    }
}
