using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.ItemCreation;

public class ScribeScroll : Characters.Feats.Feat
{
    public ScribeScroll() : base("Scribe Scroll", FeatType.ItemCreation) {
        Prerequisites = [
            new ValuePrerequisite("Lvl", 1)
        ];
    }

    public override bool CanAcquire() {
        return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
    }

    public override void ApplyBenefits() {
        throw new NotImplementedException();
    }
}