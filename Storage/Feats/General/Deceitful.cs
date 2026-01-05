using Domain.Characters.Feat;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class Deceitful() : Feat("Deceitful")
{
    public override bool CanAcquire(Player.Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player.Player player) {
        player.GetMatchingSkill("Bluff").Bonus.SetMiscMod(
            player.GetMatchingSkill("Bluff").Bonus.Ranks >= 10 ? 4 : 2);

        player.GetMatchingSkill("Disguise").Bonus.SetMiscMod(
            player.GetMatchingSkill("Disguise").Bonus.Ranks >= 10 ? 4 : 2);
    }
}