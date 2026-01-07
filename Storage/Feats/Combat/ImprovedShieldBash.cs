using Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;
using Domain.Characters.Player;

namespace Storage.Feats.Combat;

public class ImprovedShieldBash : Feat
{
    public ImprovedShieldBash() : base("Improved Shield Bash", FeatType.Combat) {
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