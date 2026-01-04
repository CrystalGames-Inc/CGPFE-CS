using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class Mobility : Characters.Feats.Feat
{
    public Mobility() : base("Mobility", FeatType.Combat)
    {
        Prerequisites = [
            new ValuePrerequisite("Dex", 13),
            new FeatPrerequisite("Dodge")
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