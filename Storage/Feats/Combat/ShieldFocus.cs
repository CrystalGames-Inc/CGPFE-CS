using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ShieldFocus : Characters.Feats.Feat
{
    public ShieldFocus() : base("Shield Focus", FeatType.Combat)
    {
        Prerequisites = [
            new FeatPrerequisite("Shield Proficiency"),
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