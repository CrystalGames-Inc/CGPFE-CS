using Domain.Characters.Feat;
using Domain.Characters.Feat.Prerequisites;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class GreaterSpellPenetration : Feat
{
    public GreaterSpellPenetration() : base("Greater Spell Penetration") {
        Prerequisites = [
            new FeatPrerequisite("Spell Penetration")
        ];
    }

    public override bool CanAcquire(Player.Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player.Player player) {
        throw new NotImplementedException();
    }
}