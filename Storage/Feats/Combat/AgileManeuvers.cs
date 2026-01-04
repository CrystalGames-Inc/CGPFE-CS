using CGPFE.Core.Enums;
using Attribute = CGPFE.Core.Enums.Attribute;
using Domain.Characters.Feat;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class AgileManeuvers() : Feat("Agile Maneuvers", FeatType.Combat)
{

    public override bool CanAcquire(Domain.Characters.Player.Player player)
    {
        return true;
    }

    public override void ApplyBenefits(ref Player.Player player)
    {
        player.CombatInfo.CmbCalcBonus = Attribute.Dexterity;
    }
}