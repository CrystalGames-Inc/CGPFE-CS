using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class VitalStrike : Characters.Feats.Feat
{
    public VitalStrike() : base("Vital Strike", FeatType.Combat)
    {
        Prerequisites = [
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