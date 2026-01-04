using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class GreatCleave : Characters.Feats.Feat
{
    public GreatCleave() : base("Great Cleave", FeatType.Combat)
    {
        Prerequisites = [
            new ValuePrerequisite("Str", 13),
            new FeatPrerequisite("Cleave"),
            new FeatPrerequisite("Power Attack"),
            new ValuePrerequisite("Bab", 4)
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