using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Critical;

public class BleedingCritical : Characters.Feats.Feat
{
    public BleedingCritical() : base("Bleeding Critical", FeatType.Critical) {
        Prerequisites = [

        ];
    }

    public override bool CanAcquire() {
        return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
    }

    public override void ApplyBenefits() {
        throw new NotImplementedException();
    }
}