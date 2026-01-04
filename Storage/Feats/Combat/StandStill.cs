using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class StandStill : Characters.Feats.Feat
{
    public StandStill() : base("Stand Still", FeatType.Combat)
    {
        Prerequisites = [
            new FeatPrerequisite("Combat Reflexes")
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