namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class Alertness() : Characters.Feats.Feat("Alertness")
{
    public override bool CanAcquire() {
        return true;
    }

    public override void ApplyBenefits() {
        PlayerDataManager.Instance.Player.GetMatchingSkill("Perception").Bonus.SetMiscMod(
            PlayerDataManager.Instance.Player.GetMatchingSkill("Perception").Bonus.Ranks >= 10 ? 4 : 2);

        PlayerDataManager.Instance.Player.GetMatchingSkill("Sense Motive").Bonus.SetMiscMod(
            PlayerDataManager.Instance.Player.GetMatchingSkill("Sense Motive").Bonus.Ranks >= 10 ? 4 : 2);
    }
}