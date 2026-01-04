using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.ItemCreation;

public class CraftWand : Characters.Feats.Feat
{
    public CraftWand() : base("Craft Wand", FeatType.ItemCreation) {
        Prerequisites = [
            new ValuePrerequisite("Lvl", 5)
        ];
    }

    public override bool CanAcquire() {
        return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
    }

    public override void ApplyBenefits() {
        throw new NotImplementedException();
    }
}