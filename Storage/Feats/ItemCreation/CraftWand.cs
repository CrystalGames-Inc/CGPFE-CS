using Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;
using Domain.Characters.Player;

namespace Storage.Feats.ItemCreation;

public class CraftWand : Feat
{
    public CraftWand() : base("Craft Wand", FeatType.ItemCreation) {
        Prerequisites = [
            new ValuePrerequisite("Lvl", 5)
        ];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}