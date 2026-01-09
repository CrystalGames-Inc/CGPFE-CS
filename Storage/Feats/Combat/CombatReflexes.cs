using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Player;
using CGPFE.Core.Enums;

namespace Storage.Feats.Combat;

public class CombatReflexes() : Feat("Combat Reflexes", FeatType.Combat)
{
    public override bool CanAcquire(Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}
