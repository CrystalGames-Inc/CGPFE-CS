using Domain.Characters.Feat;
using Domain.Characters.Player;

namespace Storage.Feats.General;

public class SelfSufficient() : Feat("Self-Sufficient")
{
    public override bool CanAcquire(Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player player) {
        player.GetMatchingSkill("Heal").Bonus.SetMiscMod(
            player.GetMatchingSkill("Heal").Bonus.Ranks >= 10 ? 4 : 2);

        player.GetMatchingSkill("Survival").Bonus.SetMiscMod(
            player.GetMatchingSkill("Survival").Bonus.Ranks >= 10 ? 4 : 2);
    }
}