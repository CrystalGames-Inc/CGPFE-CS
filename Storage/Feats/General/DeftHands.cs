using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Player;

namespace Storage.Feats.General;

public class DeftHands() : Feat("Deft Hands")
{
    public override bool CanAcquire(Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player player) {
        player.GetMatchingSkill("Disable Device").Bonus.SetMiscMod(
            player.GetMatchingSkill("Disable Device").Bonus.Ranks >= 10 ? 4 : 2);

        player.GetMatchingSkill("Sleight Of Hand").Bonus.SetMiscMod(
            player.GetMatchingSkill("Sleight Of Hand").Bonus.Ranks >= 10 ? 4 : 2);
    }
}
