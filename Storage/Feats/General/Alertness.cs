using Domain.Characters.Feat;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class Alertness() : Feat("Alertness")
{
    public override bool CanAcquire(Player.Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player.Player player) {
        player.GetMatchingSkill("Perception").Bonus.SetMiscMod(
            player.GetMatchingSkill("Perception").Bonus.Ranks >= 10 ? 4 : 2);

        player.GetMatchingSkill("Sense Motive").Bonus.SetMiscMod(
            player.GetMatchingSkill("Sense Motive").Bonus.Ranks >= 10 ? 4 : 2);
    }
}