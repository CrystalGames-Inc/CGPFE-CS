using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Metamagic;

public class ExtendSpell() : Characters.Feats.Feat("Extend Spell", FeatType.Metamagic)
{
    public override bool CanAcquire()
    {
        return true;
    }

    public override void ApplyBenefits()
    {
        throw new NotImplementedException();
    }
}