using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Critical;

public class ExhaustingCritical : Characters.Feats.Feat
{
    public ExhaustingCritical() : base("Exhausting Critical", FeatType.Critical)
    {
        Prerequisites = [
            new FeatPrerequisite("Critical Focus"),
            new FeatPrerequisite("Tiring Critical"),
            new ValuePrerequisite("Bab", 15)
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