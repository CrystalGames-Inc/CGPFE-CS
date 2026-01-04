using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.ItemCreation;

public class CraftMagicArmsArmor : Characters.Feats.Feat
{
    public CraftMagicArmsArmor() : base("Craft Magic Arms and Armor", FeatType.ItemCreation) {
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