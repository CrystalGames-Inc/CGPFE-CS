using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class CombatExpertise : Characters.Feats.Feat
{
    public CombatExpertise() : base("Combat Expertise", FeatType.Combat)
    {
        Prerequisites = [
            new ValuePrerequisite("Int", 13)
        ];
    }

    public override bool CanAcquire()
    {
        return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
    }

    public override void ApplyBenefits()
    {
        throw new NotImplementedException();
    }
}