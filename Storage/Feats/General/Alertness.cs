using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Player;
using CGPFE.Storage.Skills;

namespace Storage.Feats.General;

public class Alertness() : Feat("Alertness")
{
    public override bool CanAcquire(Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player player) {
        player.GetMatchingSkill("Perception", [..Skills.skills]).Bonus.SetMiscMod(
            player.GetMatchingSkill("Perception", [..Skills.skills]).Bonus.Ranks >= 10 ? 4 : 2);

        player.GetMatchingSkill("Sense Motive", [..Skills.skills]).Bonus.SetMiscMod(
            player.GetMatchingSkill("Sense Motive", [..Skills.skills]).Bonus.Ranks >= 10 ? 4 : 2);
    }
}
