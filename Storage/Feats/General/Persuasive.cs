namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class Persuasive() : Characters.Feats.Feat("Persuasive")
{
    public override bool CanAcquire() {
        return true;
    }

    public override void ApplyBenefits() {
        PlayerDataManager.Instance.Player.GetMatchingSkill("Diplomacy").Bonus.SetMiscMod(
            PlayerDataManager.Instance.Player.GetMatchingSkill("Diplomacy").Bonus.Ranks >= 10 ? 4 : 2);

        PlayerDataManager.Instance.Player.GetMatchingSkill("Intimidate").Bonus.SetMiscMod(
            PlayerDataManager.Instance.Player.GetMatchingSkill("Intimidate").Bonus.Ranks >= 10 ? 4 : 2);
    }
}