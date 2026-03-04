using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Player;
using CGPFE.Storage.Skills;

namespace Storage.Feats.General;

public class Persuasive() : Feat("Persuasive")
{
    public override bool CanAcquire(Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player player) {
        player.GetMatchingSkill("Diplomacy", [.. Skills.skills]).Bonus.
            ChangeMiscMod(player.GetMatchingSkill("Diplomacy", [.. Skills.skills]).Bonus.Ranks >= 10 ? 4 : 2);
        player.GetMatchingSkill("Intimidation", [.. Skills.skills]).Bonus.
            ChangeMiscMod(player.GetMatchingSkill("Intimidation", [.. Skills.skills]).Bonus.Ranks >= 10 ? 4 : 2);
    }
}
