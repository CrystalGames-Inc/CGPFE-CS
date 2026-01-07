using Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Player;

namespace Storage.Feats.Metamagic;

public class SilentSpell() : Feat("Silent Spell", FeatType.Metamagic)
{
    public override bool CanAcquire(Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}