using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class GreaterDisarm : Characters.Feats.Feat
{
    public GreaterDisarm() : base("Greater Disarm", FeatType.Combat)
    {
        Prerequisites = [
            new FeatPrerequisite("Combat Expertise"),
            new FeatPrerequisite("Improved Disarm"),
            new ValuePrerequisite("Bab", 6),
            new ValuePrerequisite("Int", 13)
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