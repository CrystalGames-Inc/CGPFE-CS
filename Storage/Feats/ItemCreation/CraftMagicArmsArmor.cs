using CGPFE.Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;

namespace CGPFE.Domain.Characters.Feats.Feats.ItemCreation;

public class CraftMagicArmsArmor : Feat
{
    public CraftMagicArmsArmor() : base("Craft Magic Arms and Armor", FeatType.ItemCreation) {
        Prerequisites = [
            new ValuePrerequisite("Lvl", 5)
        ];
    }

    public override bool CanAcquire(Player.Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player.Player player) {
        throw new NotImplementedException();
    }
}