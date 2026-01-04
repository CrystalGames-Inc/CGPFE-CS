using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Metamagic;

public class SilentSpell() : Characters.Feats.Feat("Silent Spell", FeatType.Metamagic)
{
    public override bool CanAcquire() {
        return true;
    }

    public override void ApplyBenefits() {
        throw new NotImplementedException();
    }
}