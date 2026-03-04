using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Player;
using CGPFE.Storage.Skills;

namespace Storage.Feats.General;

public class Deceitful() : Feat("Deceitful")
{
    public override bool CanAcquire(Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player player) {
        player.GetMatchingSkill("Bluff", [.. Skills.skills]).Bonus.
    ChangeMiscMod(player.GetMatchingSkill("Bluff", [.. Skills.skills]).Bonus.Ranks >= 10 ? 4 : 2);

        player.GetMatchingSkill("Disguise", [.. Skills.skills]).Bonus.
    ChangeMiscMod(player.GetMatchingSkill("Disguise", [.. Skills.skills]).Bonus.Ranks >= 10 ? 4 : 2);
    }
}
