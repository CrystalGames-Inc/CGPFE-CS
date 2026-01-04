namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class Deceitful() : Characters.Feats.Feat("Deceitful")
{
    public override bool CanAcquire()
    {
        return true;
    }

    public override void ApplyBenefits()
    {
        PlayerDataManager.Instance.Player.GetMatchingSkill("Bluff").Bonus.SetMiscMod(
            PlayerDataManager.Instance.Player.GetMatchingSkill("Bluff").Bonus.Ranks >= 10 ? 4 : 2);

        PlayerDataManager.Instance.Player.GetMatchingSkill("Disguise").Bonus.SetMiscMod(
            PlayerDataManager.Instance.Player.GetMatchingSkill("Disguise").Bonus.Ranks >= 10 ? 4 : 2);
    }
}