using Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;
using Domain.Characters.Player;

namespace Storage.Feats.Critical;

public class TiringCritical : Feat
{
    public TiringCritical() : base("Tiring Critical", FeatType.Critical) {
        Prerequisites = [
            new FeatPrerequisite("Critical Focus"),
            new ValuePrerequisite("Bab", 13)
        ];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}