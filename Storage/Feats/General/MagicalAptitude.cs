using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Player;
using CGPFE.Storage.Skills;

namespace Storage.Feats.General;

public class MagicalAptitude() : Feat("Magical Aptitude")
{
    public override bool CanAcquire(Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player player) {
        player.GetMatchingSkill("Spellcraft", [.. Skills.skills]).Bonus.
            ChangeMiscMod(player.GetMatchingSkill("Spellcraft", [.. Skills.skills]).Bonus.Ranks >= 10 ? 4 : 2);
        player.GetMatchingSkill("Use Magic Item", [.. Skills.skills]).Bonus.
            ChangeMiscMod(player.GetMatchingSkill("Use Magic item", [.. Skills.skills]).Bonus.Ranks >= 10 ? 4 : 2);
    }
}
