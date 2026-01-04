using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ImprovedGrapple : Characters.Feats.Feat
{
    public ImprovedGrapple() : base("Improved Grapple", FeatType.Combat)
    {
        Prerequisites = [
            new ValuePrerequisite("Dex", 13),
            new FeatPrerequisite("Improved Unarmed Strike")
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