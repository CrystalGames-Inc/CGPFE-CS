using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ImprovedTwoWeaponFighting : Characters.Feats.Feat
{
    public ImprovedTwoWeaponFighting() : base("Improved Two-Weapon Fighting", FeatType.Combat)
    {
        Prerequisites = [
            new ValuePrerequisite("Dex", 17),
            new FeatPrerequisite("Two-Weapon Fighting"),
            new ValuePrerequisite("Bab", 6)
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