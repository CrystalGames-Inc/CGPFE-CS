using Domain.Characters.Feat;
using Domain.Characters.Player;

namespace Storage.Feats.General;

public class AnimalAffinity() : Feat("Animal Affinity")
{
    public override bool CanAcquire(Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player player) {
        player.GetMatchingSkill("Handle Animal").Bonus.SetMiscMod(
            player.GetMatchingSkill("Handle Animal").Bonus.Ranks >= 10 ? 4 : 2);

        player.GetMatchingSkill("Ride").Bonus.SetMiscMod(
            player.GetMatchingSkill("Ride").Bonus.Ranks >= 10 ? 4 : 2);
    }
}