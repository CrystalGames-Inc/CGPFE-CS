using CGPFE.Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class CriticalMastery : Feat
{
    public CriticalMastery() : base("Critical Mastery", FeatType.Combat)
    {
        Prerequisites = [
            new FeatPrerequisite("Critical Focus"),
            new ValuePrerequisite("Lvl", 14),
            new ValuePrerequisite("Cls", 7, "==")
        ];
    }

    public override bool CanAcquire(Player.Player player)
    {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player.Player player)
    {
        throw new NotImplementedException();
    }
}