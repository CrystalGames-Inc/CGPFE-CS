using Domain.Characters.Feat;
using Domain.Characters.Player;
using Core.Enums;

namespace Storage.Feats.Metamagic;

public class EmpowerSpell() : Feat("Empower Spell", FeatType.Metamagic)
{
    public override bool CanAcquire(Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}
