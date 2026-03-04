using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Player;
using CGPFE.Storage.Skills;

namespace Storage.Feats.General;

public class AnimalAffinity() : Feat("Animal Affinity")
{
    public override bool CanAcquire(Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player player) {
        player.GetMatchingSkill("Handle Animal", [..Skills.skills]).Bonus.SetMiscMod(
            player.GetMatchingSkill("Handle Animal", [..Skills.skills]).Bonus.Ranks >= 10 ? 4 : 2);

        player.GetMatchingSkill("Ride", [..Skills.skills]).Bonus.SetMiscMod(
            player.GetMatchingSkill("Ride", [..Skills.skills]).Bonus.Ranks >= 10 ? 4 : 2);
    }
}
