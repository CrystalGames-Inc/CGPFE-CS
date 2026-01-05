using Domain.Characters.Feat;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class Stealthy() : Feat("Stealthy")
{
    public override bool CanAcquire(Player.Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player.Player player) {
        player.GetMatchingSkill("Escape Artist").Bonus.SetMiscMod(
            player.GetMatchingSkill("Escape Artist").Bonus.Ranks >= 10 ? 4 : 2);

        player.GetMatchingSkill("Stealth").Bonus.SetMiscMod(
            player.GetMatchingSkill("Stealth").Bonus.Ranks >= 10 ? 4 : 2);
    }
}