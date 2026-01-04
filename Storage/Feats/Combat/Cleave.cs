using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class Cleave : Characters.Feats.Feat
{
    public Cleave() : base("Cleave", FeatType.Combat)
    {
        Prerequisites = [
            new ValuePrerequisite("Str", 13),
            new FeatPrerequisite("Power Attack"),
            new ValuePrerequisite("Bab", 1)
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