using CGPFE.Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class TwoWeaponDefense : Feat
{
    public TwoWeaponDefense() : base("Two Weapon Defense", FeatType.Combat) {
        Prerequisites = [
            new ValuePrerequisite("Dex", 15),
            new FeatPrerequisite("Two-Weapon Fighting")
        ];
    }

    public override bool CanAcquire(Player.Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player.Player player) {
        throw new NotImplementedException();
    }
}