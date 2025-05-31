using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class Athletic() : Domain.Characters.Feats.Properties.Feat("Athletic") {
    public override bool CanAcquire()
    {
        return true;
    }

    public override void Benefits()
    {
        PlayerDataManager.Instance.Player.GetMatchingSkill("Climb").Bonus.SetMiscMod(
            PlayerDataManager.Instance.Player.GetMatchingSkill("Climb").Bonus.Ranks >= 10 ? 4 : 2);

        PlayerDataManager.Instance.Player.GetMatchingSkill("Swim").Bonus.SetMiscMod(
            PlayerDataManager.Instance.Player.GetMatchingSkill("Swim").Bonus.Ranks >= 10 ? 4 : 2);
    }
}