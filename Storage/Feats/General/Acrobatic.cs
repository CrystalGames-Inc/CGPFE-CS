using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Player;
using CGPFE.Storage.Skills;

namespace Storage.Feats.General;

public class Acrobatic() : Feat("Acrobatic")
{
    public override bool CanAcquire(Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player player) {
        player.GetMatchingSkill("Acrobatics", [..Skills.skills]).Bonus.SetMiscMod(
            player.GetMatchingSkill("Acrobatics", [..Skills.skills]).Bonus.Ranks >= 10 ? 4 : 2);

        player.GetMatchingSkill("Fly", [..Skills.skills]).Bonus.SetMiscMod(
            player.GetMatchingSkill("Fly", [..Skills.skills]).Bonus.Ranks >= 10 ? 4 : 2);
    }
}
