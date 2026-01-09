using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;
using Domain.Characters.Player;
using Core.Enums;

namespace Storage.Feats.Combat;

public class DazzlingDisplay : Feat
{
    public DazzlingDisplay() : base("Dazzling Display", FeatType.Combat) {
        Prerequisites = [
            new FeatPrerequisite("Weapon Focus")
        ];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}
