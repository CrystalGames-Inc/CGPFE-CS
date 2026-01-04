using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class DefensiveCombatTraining() : Characters.Feats.Feat("Defensive Combat Training", FeatType.Combat)
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