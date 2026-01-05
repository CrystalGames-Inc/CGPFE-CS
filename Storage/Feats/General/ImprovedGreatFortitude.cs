using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class ImprovedGreatFortitude : Feat
{
    public ImprovedGreatFortitude() : base("Improved Great Fortitude") {
        Prerequisites = [
            new FeatPrerequisite("Great Fortitude")
        ];
    }

    public override bool CanAcquire(Player.Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player.Player player) {
        throw new NotImplementedException();
    }
}