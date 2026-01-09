using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Player;

namespace Storage.Feats.General;

public class MagicalAptitude() : Feat("Magical Aptitude")
{
    public override bool CanAcquire(Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player player) {
        player.GetMatchingSkill("Spellcraft").Bonus.SetMiscMod(
            player.GetMatchingSkill("Spellcraft").Bonus.Ranks >= 10 ? 4 : 2);

        player.GetMatchingSkill("Use Magic Device").Bonus.SetMiscMod(
            player.GetMatchingSkill("Use Magic Device").Bonus.Ranks >= 10 ? 4 : 2);
    }
}
