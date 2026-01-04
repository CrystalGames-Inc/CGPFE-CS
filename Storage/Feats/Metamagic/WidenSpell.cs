using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Metamagic;

public class WidenSpell() : Characters.Feats.Feat("Widen", FeatType.Metamagic)
{
    public override bool CanAcquire() {
        return true;
    }

    public override void ApplyBenefits() {
        throw new NotImplementedException();
    }
}