using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Player;
using Attribute = CGPFE.Core.Enums.Attribute;

namespace CGPFE.Storage.Feats.Combat;

public class AgileManeuvers() : Feat("Agile Maneuvers", FeatType.Combat) {

    public override bool CanAcquire(Player player) {
        return true;
    }

    public override void ApplyBenefits(ref Player player) {
        player.CombatInfo.CmbCalcBonus = Attribute.Dexterity;
    }
}