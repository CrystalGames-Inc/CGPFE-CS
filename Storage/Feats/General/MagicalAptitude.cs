using Domain.Characters.Feat;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class MagicalAptitude() : Feat("Magical Aptitude")
{
    public override bool CanAcquire(Player.Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player.Player player) {
        player.GetMatchingSkill("Spellcraft").Bonus.SetMiscMod(
            player.GetMatchingSkill("Spellcraft").Bonus.Ranks >= 10 ? 4 : 2);

        player.GetMatchingSkill("Use Magic Device").Bonus.SetMiscMod(
            player.GetMatchingSkill("Use Magic Device").Bonus.Ranks >= 10 ? 4 : 2);
    }
}