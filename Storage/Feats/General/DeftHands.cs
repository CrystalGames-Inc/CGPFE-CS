using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Player;
using CGPFE.Storage.Skills;

namespace Storage.Feats.General;

public class DeftHands() : Feat("Deft Hands")
{
    public override bool CanAcquire(Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player player) {
        player.GetMatchingSkill("Disable Device", [.. Skills.skills]).Bonus.
    ChangeMiscMod(player.GetMatchingSkill("Disable Device", [.. Skills.skills]).Bonus.Ranks >= 10 ? 4 : 2);

        player.GetMatchingSkill("Sleight of Hand", [.. Skills.skills]).Bonus.
    ChangeMiscMod(player.GetMatchingSkill("Sleight of Hand", [.. Skills.skills]).Bonus.Ranks >= 10 ? 4 : 2);
    }
}
