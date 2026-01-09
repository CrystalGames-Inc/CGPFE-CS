using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Feat.Prerequisites;
using CGPFE.Domain.Characters.Player;
using CGPFE.Core.Enums;

namespace Storage.Feats.ItemCreation;

public class CraftStaff : Feat
{
    public CraftStaff() : base("Craft Staff", FeatType.ItemCreation) {
        Prerequisites = [
            new ValuePrerequisite("Lvl", 11)
        ];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}
