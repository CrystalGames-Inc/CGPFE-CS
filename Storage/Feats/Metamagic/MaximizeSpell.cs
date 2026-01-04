using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Metamagic;

public class MaximizeSpell() : Characters.Feats.Feat("Maximize Spell", FeatType.Metamagic)
{
    public override bool CanAcquire() {
        return true;
    }

    public override void ApplyBenefits() {
        throw new NotImplementedException();
    }
}