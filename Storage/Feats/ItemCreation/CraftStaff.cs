using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.ItemCreation;

public class CraftStaff : Characters.Feats.Feat
{
    public CraftStaff() : base("Craft Staff", FeatType.ItemCreation)
    {
        Prerequisites = [
            new ValuePrerequisite("Lvl", 11)
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