using CGPFE.Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class LightningStance : Feat
{
    public LightningStance() : base("Lightning Stance", FeatType.Combat) {
        Prerequisites = [
            new ValuePrerequisite("Dex", 17),
            new FeatPrerequisite("Dodge"),
            new FeatPrerequisite("Wind Stance"),
            new ValuePrerequisite("Bab", 11)
        ];
    }

    public override bool CanAcquire(Player.Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player.Player player) {
        throw new NotImplementedException();
    }
}