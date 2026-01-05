using Domain.Characters.Feat;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class Athletic() : Feat("Athletic")
{
    public override bool CanAcquire(Player.Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player.Player player) {
        player.GetMatchingSkill("Climb").Bonus.SetMiscMod(
            player.GetMatchingSkill("Climb").Bonus.Ranks >= 10 ? 4 : 2);

        player.GetMatchingSkill("Swim").Bonus.SetMiscMod(
            player.GetMatchingSkill("Swim").Bonus.Ranks >= 10 ? 4 : 2);
    }
}