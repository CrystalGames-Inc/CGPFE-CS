using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ExoticWeaponProficiency : Characters.Feats.Feat
{
    public ExoticWeaponProficiency() : base("Exotic Weapon Proficiency", FeatType.Combat)
    {
        Prerequisites = [
            new ValuePrerequisite("Bab", 1)
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