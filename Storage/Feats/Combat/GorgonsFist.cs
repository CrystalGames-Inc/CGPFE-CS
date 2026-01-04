using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class GorgonsFist : Characters.Feats.Feat
{
    public GorgonsFist() : base("Gorgon's Fist", FeatType.Combat)
    {
        Prerequisites = [
            new FeatPrerequisite("Improved Unarmed Strike"),
            new FeatPrerequisite("Scorpion Style"),
            new ValuePrerequisite("Bab", 6)
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