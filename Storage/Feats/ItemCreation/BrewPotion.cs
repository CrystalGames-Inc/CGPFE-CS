using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.ItemCreation;

public class BrewPotion : Characters.Feats.Feat
{
    public BrewPotion() : base("Brew Potion", FeatType.ItemCreation)
    {
        Prerequisites = [
            new ValuePrerequisite("Lvl", 3)
        ];
    }

    public override bool CanAcquire()
    {
        return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
    }

    public override void ApplyBenefits()
    {
        throw new NotImplementedException();
    }
}