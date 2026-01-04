using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class StrikeBack : Characters.Feats.Feat
{
    public StrikeBack() : base("Strike Back", FeatType.Combat)
    {
        Prerequisites = [
            new ValuePrerequisite("Bab", 11)
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