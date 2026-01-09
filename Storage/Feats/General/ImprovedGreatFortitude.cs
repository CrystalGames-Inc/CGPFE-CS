using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Feat.Prerequisites;
using CGPFE.Domain.Characters.Player;

namespace Storage.Feats.General;

public class ImprovedGreatFortitude : Feat
{
    public ImprovedGreatFortitude() : base("Improved Great Fortitude") {
        Prerequisites = [
            new FeatPrerequisite("Great Fortitude")
        ];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}
