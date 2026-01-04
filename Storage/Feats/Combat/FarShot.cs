using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class FarShot : Characters.Feats.Feat
{
    public FarShot() : base("Far Shot", FeatType.Combat)
    {
        Prerequisites = [
            new FeatPrerequisite("Point-Blank Shot")
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