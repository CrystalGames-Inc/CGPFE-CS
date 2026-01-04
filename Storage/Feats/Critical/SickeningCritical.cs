using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Critical;

public class SickeningCritical : Characters.Feats.Feat
{
    public SickeningCritical() : base("Sickening Critical", FeatType.Critical) {
        Prerequisites = [
            new FeatPrerequisite("Critical Focus"),
            new ValuePrerequisite("Bab", 11)
        ];
    }

    public override bool CanAcquire() {
        return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
    }

    public override void ApplyBenefits() {
        throw new NotImplementedException();
    }
}