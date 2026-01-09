using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;
using Domain.Characters.Player;
using Core.Enums;

namespace Storage.Feats.Combat;

public class TowerShieldProficiency : Feat
{
    public TowerShieldProficiency() : base("Tower Shield Proficiency", FeatType.Combat) {
        Prerequisites = [
            new FeatPrerequisite("Shield Proficiency")
        ];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}
