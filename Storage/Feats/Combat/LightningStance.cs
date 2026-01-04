using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class LightningStance : Characters.Feats.Feat
{
    public LightningStance() : base("Lightning Stance", FeatType.Combat)
    {
        Prerequisites = [
            new ValuePrerequisite("Dex", 17),
            new FeatPrerequisite("Dodge"),
            new FeatPrerequisite("Wind Stance"),
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