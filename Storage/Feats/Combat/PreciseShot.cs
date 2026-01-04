using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class PreciseShot : Characters.Feats.Feat
{
    public PreciseShot() : base("Precise Shot", FeatType.Combat)
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