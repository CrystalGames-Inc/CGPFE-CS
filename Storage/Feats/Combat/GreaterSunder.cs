using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class GreaterSunder : Characters.Feats.Feat
{
    public GreaterSunder() : base("Greater Sunder", FeatType.Combat)
    {
        Prerequisites = [
            new FeatPrerequisite("Improved Sunder"),
            new FeatPrerequisite("Power Attack"),
            new ValuePrerequisite("Bab", 6),
            new ValuePrerequisite("Str", 13)
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