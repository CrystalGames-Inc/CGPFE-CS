using CGPFE.Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class Manyshot : Feat
{
    public Manyshot() : base("Manyshot", FeatType.Combat) {
        Prerequisites = [
            new ValuePrerequisite("Dex", 17),
            new FeatPrerequisite("Point-Blank Shot"),
            new FeatPrerequisite("Rapid Shot"),
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