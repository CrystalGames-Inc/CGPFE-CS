using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class DazzlingDisplay : Characters.Feats.Feat
{
    public DazzlingDisplay() : base("Dazzling Display", FeatType.Combat)
    {
        Prerequisites = [
            new FeatPrerequisite("Weapon Focus")
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