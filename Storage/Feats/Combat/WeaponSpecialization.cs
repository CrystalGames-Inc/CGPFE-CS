using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class WeaponSpecialization : Characters.Feats.Feat
{
    public WeaponSpecialization() : base("Weapon Specialization", FeatType.Combat)
    {
        Prerequisites = [
            new FeatPrerequisite("Weapon Focus"),
            new ValuePrerequisite("Cls", 7),
            new ValuePrerequisite("Lvl", 4)
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