using Domain.Characters.Feat;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class SelfSufficient() : Feat("Self-Sufficient")
{
    public override bool CanAcquire(Player.Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player.Player player) {
        player.GetMatchingSkill("Heal").Bonus.SetMiscMod(
            player.GetMatchingSkill("Heal").Bonus.Ranks >= 10 ? 4 : 2);

        player.GetMatchingSkill("Survival").Bonus.SetMiscMod(
            player.GetMatchingSkill("Survival").Bonus.Ranks >= 10 ? 4 : 2);
    }
}