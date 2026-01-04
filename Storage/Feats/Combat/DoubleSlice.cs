using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class DoubleSlice : Characters.Feats.Feat
{
    public DoubleSlice() : base("Double Slice", FeatType.Combat)
    {
        Prerequisites = [
            new ValuePrerequisite("Dex", 15),
            new FeatPrerequisite("Two-WeaponFighting")
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