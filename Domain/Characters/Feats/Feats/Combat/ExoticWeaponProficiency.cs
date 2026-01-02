using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ExoticWeaponProficiency: Domain.Characters.Feats.Properties.Feat
{
    public ExoticWeaponProficiency() : base("Exotic Weapon Proficiency", FeatType.Combat) {
        Prerequisites = [
            new ValuePrerequisite("Bab", 1)
        ];
    }

    public override bool CanAcquire() {
        return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
    }

    public override void Benefits() {
        throw new NotImplementedException();
    }
}