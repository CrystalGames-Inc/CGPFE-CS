using Domain.Characters.Feat;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class Persuasive() : Feat("Persuasive")
{
    public override bool CanAcquire(Player.Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player.Player player) {
        player.GetMatchingSkill("Diplomacy").Bonus.SetMiscMod(
            player.GetMatchingSkill("Diplomacy").Bonus.Ranks >= 10 ? 4 : 2);

        player.GetMatchingSkill("Intimidate").Bonus.SetMiscMod(
            player.GetMatchingSkill("Intimidate").Bonus.Ranks >= 10 ? 4 : 2);
    }
}