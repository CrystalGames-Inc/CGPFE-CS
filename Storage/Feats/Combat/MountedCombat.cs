using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class MountedCombat : Characters.Feats.Feat
{
    public MountedCombat() : base("Mounted Combat", FeatType.Combat)
    {
        Prerequisites = [
            new SkillRankPrerequisite("Ride", 1)
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