using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Player;
using Domain.Characters.Feat;

namespace CGPFE.Storage.Feats.Combat;

public class BlindFight : Feat
{
    public BlindFight() : base("Blind-Fight", FeatType.Combat) { }

    public override bool CanAcquire(Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}