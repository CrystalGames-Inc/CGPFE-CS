using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class TwoWeaponFighting : Characters.Feats.Feat
{
    public TwoWeaponFighting() : base("Two-Weapon Fighting", FeatType.Combat)
    {
        Prerequisites = [
            new ValuePrerequisite("Dex", 15)
        ];
    }

    public override bool CanAcquire()
    {
        return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
    }

    public override void ApplyBenefits()
    {
        throw new NotImplementedException();
    }
}