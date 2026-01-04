using CGPFE.Core.Enums;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ScorpionStyle : Characters.Feats.Feat
{
    public ScorpionStyle() : base("Scorpion Style", FeatType.Combat)
    {
        Prerequisites = [
            new FeatPrerequisite("Improved Unarmed Strike")
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