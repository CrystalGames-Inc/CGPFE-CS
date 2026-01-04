using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Critical;

public class TiringCritical : Characters.Feats.Feat
{
    public TiringCritical() : base("Tiring Critical", FeatType.Critical) {
        Prerequisites = [
            new FeatPrerequisite("Critical Focus"),
            new ValuePrerequisite("Bab", 13)
        ];
    }

    public override bool CanAcquire() {
        return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
    }

    public override void ApplyBenefits() {
        throw new NotImplementedException();
    }
}