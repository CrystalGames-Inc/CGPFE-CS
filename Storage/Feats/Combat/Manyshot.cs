using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class Manyshot : Characters.Feats.Feat
{
    public Manyshot() : base("Manyshot", FeatType.Combat)
    {
        Prerequisites = [
            new ValuePrerequisite("Dex", 17),
            new FeatPrerequisite("Point-Blank Shot"),
            new FeatPrerequisite("Rapid Shot"),
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