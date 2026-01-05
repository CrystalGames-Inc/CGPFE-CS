using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class NimbleMoves : Feat
{
    public NimbleMoves() : base("Nimble Moves") {
        Prerequisites = [
            new ValuePrerequisite("Dex", 13)
        ];
    }

    public override bool CanAcquire(Player.Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player.Player player) {
        throw new NotImplementedException();
    }
}