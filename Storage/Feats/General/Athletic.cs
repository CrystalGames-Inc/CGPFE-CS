using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Player;
using CGPFE.Storage.Skills;

namespace Storage.Feats.General;

public class Athletic() : Feat("Athletic")
{
    public override bool CanAcquire(Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player player) {
        player.GetMatchingSkill("Climb", [.. Skills.skills]).Bonus.
    ChangeMiscMod(player.GetMatchingSkill("Climb", [.. Skills.skills]).Bonus.Ranks >= 10 ? 4 : 2);

        player.GetMatchingSkill("Swim", [.. Skills.skills]).Bonus.
    ChangeMiscMod(player.GetMatchingSkill("Swim", [.. Skills.skills]).Bonus.Ranks >= 10 ? 4 : 2);
    }
}
