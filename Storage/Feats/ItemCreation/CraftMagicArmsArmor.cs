using Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;
using Domain.Characters.Player;

namespace Storage.Feats.ItemCreation;

public class CraftMagicArmsArmor : Feat
{
    public CraftMagicArmsArmor() : base("Craft Magic Arms and Armor", FeatType.ItemCreation) {
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