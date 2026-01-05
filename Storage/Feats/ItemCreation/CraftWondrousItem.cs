using CGPFE.Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;

namespace CGPFE.Domain.Characters.Feats.Feats.ItemCreation;

public class CraftWondrousItem : Feat
{
    public CraftWondrousItem() : base("Craft Wondrous Item", FeatType.ItemCreation) {
        Prerequisites = [
            new ValuePrerequisite("Lvl", 3)
        ];
    }

    public override bool CanAcquire(Player.Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player.Player player) {
        throw new NotImplementedException();
    }
}