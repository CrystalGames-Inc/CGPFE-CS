using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;
using Domain.Characters.Player;

namespace Storage.Feats.General;

public class ImprovedLightningReflexes : Feat
{
    public ImprovedLightningReflexes() : base("Improved Lightning Reflexes") {
        Prerequisites = [
            new FeatPrerequisite("Lightning Reflexes")
        ];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}
