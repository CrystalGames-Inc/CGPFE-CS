using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Player;
using CGPFE.Storage.Skills;

namespace Storage.Feats.General;

public class Stealthy() : Feat("Stealthy")
{
    public override bool CanAcquire(Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player player) {
        player.GetMatchingSkill("Escape Artist", [.. Skills.skills]).Bonus.
            ChangeMiscMod(player.GetMatchingSkill("Escape Artist", [.. Skills.skills]).Bonus.Ranks >= 10 ? 4 : 2);

        player.GetMatchingSkill("Stealth", [.. Skills.skills]).Bonus.
    ChangeMiscMod(player.GetMatchingSkill("Stealth", [.. Skills.skills]).Bonus.Ranks >= 10 ? 4 : 2);
    }
}
