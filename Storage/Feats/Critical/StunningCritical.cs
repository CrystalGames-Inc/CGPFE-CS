using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Critical;

public class StunningCritical : Characters.Feats.Feat
{
    public StunningCritical() : base("Stunning Critical", FeatType.Critical) {
        Prerequisites = [
            new FeatPrerequisite("Critical Focus"),
            new FeatPrerequisite("Staggering Critical"),
            new ValuePrerequisite("Bab", 17)
        ];
    }

    public override bool CanAcquire() {
        return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
    }

    public override void ApplyBenefits() {
        throw new NotImplementedException();
    }
}