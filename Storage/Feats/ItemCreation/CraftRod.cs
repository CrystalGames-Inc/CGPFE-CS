using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.ItemCreation;

public class CraftRod : Characters.Feats.Feat
{
    public CraftRod() : base("Craft Rod", FeatType.ItemCreation) {
        Prerequisites = [
            new ValuePrerequisite("Lvl", 9)
        ];
    }

    public override bool CanAcquire() {
        return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
    }

    public override void ApplyBenefits() {
        throw new NotImplementedException();
    }
}