using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ThrowAnything() : Characters.Feats.Feat("Throw Anything", FeatType.Combat)
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