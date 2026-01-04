using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.ItemCreation;

public class CraftWondrousItem : Characters.Feats.Feat
{
    public CraftWondrousItem() : base("Craft Wondrous Item", FeatType.ItemCreation) {
        Prerequisites = [
            new ValuePrerequisite("Lvl", 3)
        ];
    }

    public override bool CanAcquire() {
        return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
    }

    public override void ApplyBenefits() {
        throw new NotImplementedException();
    }
}