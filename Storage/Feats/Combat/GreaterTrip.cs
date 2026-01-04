using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class GreaterTrip : Characters.Feats.Feat
{
    public GreaterTrip() : base("Greater Trip", FeatType.Combat)
    {
        Prerequisites = [
            new FeatPrerequisite("Combat Expertise"),
            new FeatPrerequisite("Improved Trip"),
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