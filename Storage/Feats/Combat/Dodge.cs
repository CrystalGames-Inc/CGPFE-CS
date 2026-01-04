using CGPFE.Core.Enums;
using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class Dodge : Feat
{
    public Dodge() : base("Dodge", FeatType.Combat)
    {
        Prerequisites = [
            new ValuePrerequisite("Dex", 13)
        ];
    }

    public override bool CanAcquire(Player.Player player)
    {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player.Player player)
    {
        player.CombatInfo.ArmorClass += 1;
    }
}