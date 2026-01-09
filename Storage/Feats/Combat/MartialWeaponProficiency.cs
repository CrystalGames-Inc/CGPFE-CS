using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Player;
using CGPFE.Core.Enums;

namespace Storage.Feats.Combat;

public class MartialWeaponProficiency() : Feat("Martial Weapon Proficiency", FeatType.Combat)
{
    public override bool CanAcquire(Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}
