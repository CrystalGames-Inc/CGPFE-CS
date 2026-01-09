using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;
using Domain.Characters.Player;
using Core.Enums;

namespace Storage.Feats.ItemCreation;

public class CraftRod : Feat
{
    public CraftRod() : base("Craft Rod", FeatType.ItemCreation) {
        Prerequisites = [
            new ValuePrerequisite("Lvl", 9)
        ];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) { 
        throw new NotImplementedException();
    }
}
