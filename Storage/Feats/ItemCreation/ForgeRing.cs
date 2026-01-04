using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.ItemCreation;

public class ForgeRing : Characters.Feats.Feat
{
    public ForgeRing() : base("Forge Ring", FeatType.ItemCreation) {
        Prerequisites = [
            new ValuePrerequisite("Lvl", 7)
        ];
    }

    public override bool CanAcquire() {
        return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
    }

    public override void ApplyBenefits() {
        throw new NotImplementedException();
    }
}
