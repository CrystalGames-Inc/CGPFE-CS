using Domain.Characters.Feat;
using Domain.Characters.Player;

namespace Storage.Feats.General;

public class Alertness() : Feat("Alertness")
{
    public override bool CanAcquire(Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player player) {
        player.GetMatchingSkill("Perception").Bonus.SetMiscMod(
            player.GetMatchingSkill("Perception").Bonus.Ranks >= 10 ? 4 : 2);

        player.GetMatchingSkill("Sense Motive").Bonus.SetMiscMod(
            player.GetMatchingSkill("Sense Motive").Bonus.Ranks >= 10 ? 4 : 2);
    }
}
