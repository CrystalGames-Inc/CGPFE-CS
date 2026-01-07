using Domain.Characters.Feat;
using Domain.Characters.Player;

namespace Storage.Feats.General;

public class Deceitful() : Feat("Deceitful")
{
    public override bool CanAcquire(Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player player) {
        player.GetMatchingSkill("Bluff").Bonus.SetMiscMod(
            player.GetMatchingSkill("Bluff").Bonus.Ranks >= 10 ? 4 : 2);

        player.GetMatchingSkill("Disguise").Bonus.SetMiscMod(
            player.GetMatchingSkill("Disguise").Bonus.Ranks >= 10 ? 4 : 2);
    }
}