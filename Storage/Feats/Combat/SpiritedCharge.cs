using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class SpiritedCharge : Characters.Feats.Feat
{
    public SpiritedCharge() : base("Spirited Charge", FeatType.Combat)
    {
        Prerequisites = [
            new SkillRankPrerequisite("Ride", 1),
            new FeatPrerequisite("Mounted Combat"),
            new FeatPrerequisite("Ride-By Attack")
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