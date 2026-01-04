using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ShieldProficiency() : Characters.Feats.Feat("Shield Proficiency", FeatType.Combat)
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