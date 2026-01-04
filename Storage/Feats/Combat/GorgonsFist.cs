using CGPFE.Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class GorgonsFist : Feat
{
    public GorgonsFist() : base("Gorgon's Fist", FeatType.Combat)
    {
        Prerequisites = [
            new FeatPrerequisite("Improved Unarmed Strike"),
            new FeatPrerequisite("Scorpion Style"),
            new ValuePrerequisite("Bab", 6)
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