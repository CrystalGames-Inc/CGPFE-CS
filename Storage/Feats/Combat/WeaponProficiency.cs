using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Player;
using CGPFE.Core.Enums;

namespace Storage.Feats.Combat;

public class WeaponProficiency : Feat
{
    private string WeaponName { get; }

    public WeaponProficiency() : base("Weapon Proficiency", FeatType.Combat) {
    }

    public WeaponProficiency(string weaponName) : base("Weapon Proficiency", FeatType.Combat) {
        WeaponName = weaponName;
    }
    public override bool CanAcquire(Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }

}
