using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Player;
using CGPFE.Domain.Items.Equipment.Offense;

namespace CGPFE.Storage.Feats.Combat;

public class WeaponProficiency : Feat
{
    public WeaponProficiency(string weaponName) : base("Weapon Proficiency", FeatType.Combat) {
        
    }
    public override bool CanAcquire(Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }

}
