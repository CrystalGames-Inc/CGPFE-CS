using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class WindStance : Feat
{
    public WindStance() : base("Wind Stance") {
        Prerequisites = [
            new ValuePrerequisite("Dex", 15),
            new FeatPrerequisite("Dodge"),
            new ValuePrerequisite("Bab", 6)
        ];
    }

    public override bool CanAcquire(Player.Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player.Player player) {
        throw new NotImplementedException();
    }
}