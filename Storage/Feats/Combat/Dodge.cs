using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class Dodge : Characters.Feats.Feat
{
    public Dodge() : base("Dodge", FeatType.Combat)
    {
        Prerequisites = [
            new ValuePrerequisite("Dex", 13)
        ];
    }

    public override bool CanAcquire()
    {
        return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
    }

    public override void ApplyBenefits()
    {
        PlayerDataManager.Instance.Player.CombatInfo.ArmorClass += 1;
    }
}