using CGPFE.Domain.Characters.Player;
using Domain.Characters.Feat;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class Acrobatic() : Feat("Acrobatic")
{
    public override bool CanAcquire(Player.Player player)
    {
        return true;
    }

    public override void ApplyBenefits(ref Player.Player player)
    {
        player.GetMatchingSkill("Acrobatics").Bonus.SetMiscMod(
            player.GetMatchingSkill("Acrobatics").Bonus.Ranks >= 10 ? 4 : 2);

        player.GetMatchingSkill("Fly").Bonus.SetMiscMod(
            player.GetMatchingSkill("Fly").Bonus.Ranks >= 10 ? 4 : 2);
    }
}