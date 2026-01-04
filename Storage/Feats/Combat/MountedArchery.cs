using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class MountedArchery : Characters.Feats.Feat
{
    public MountedArchery() : base("Mounted Archery", FeatType.Combat)
    {
        Prerequisites = [
            new SkillRankPrerequisite("Ride", 1),
            new FeatPrerequisite("Mounted Combat")
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