using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class GreaterOverrun : Characters.Feats.Feat
{
    public GreaterOverrun() : base("Greater Overrun", FeatType.Combat)
    {
        Prerequisites = [
            new FeatPrerequisite("Improved Overrun"),
            new FeatPrerequisite("Power Attack"),
            new ValuePrerequisite("Bab", 6),
            new ValuePrerequisite("Str", 13)
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