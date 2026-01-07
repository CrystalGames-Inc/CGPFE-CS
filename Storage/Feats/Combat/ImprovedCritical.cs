using Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;
using Domain.Characters.Player;

namespace Storage.Feats.Combat;

public class ImprovedCritical : Feat
{
    public ImprovedCritical() : base("Improved Critical", FeatType.Combat) {
        Prerequisites = [

            new ValuePrerequisite("Bab", 8)
        ];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}