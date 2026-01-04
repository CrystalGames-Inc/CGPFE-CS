using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ImprovedPreciseShot : Characters.Feats.Feat
{
    public ImprovedPreciseShot() : base("Improved Precise Shot", FeatType.Combat)
    {
        Prerequisites = [
            new ValuePrerequisite("Dex", 19),
            new FeatPrerequisite("Point-Blank Shot"),
            new FeatPrerequisite("Precise Shot"),
            new ValuePrerequisite("Bab", 11)
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