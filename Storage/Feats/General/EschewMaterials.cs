using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Player;

namespace Storage.Feats.General;

public class EschewMaterials() : Feat("Eschew Materials")
{
    public override bool CanAcquire(Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}
