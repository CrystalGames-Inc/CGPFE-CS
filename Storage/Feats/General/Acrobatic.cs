using Domain.Characters.Feat;
using Domain.Characters.Player;

namespace Storage.Feats.General;

public class Acrobatic() : Feat("Acrobatic")
{
    public override bool CanAcquire(Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player player) {
        player.GetMatchingSkill("Acrobatics").Bonus.SetMiscMod(
            player.GetMatchingSkill("Acrobatics").Bonus.Ranks >= 10 ? 4 : 2);

        player.GetMatchingSkill("Fly").Bonus.SetMiscMod(
            player.GetMatchingSkill("Fly").Bonus.Ranks >= 10 ? 4 : 2);
    }
}