using CGPFE.Core.Enums;
using Domain.Characters.Feat;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class RapidReload : Feat
{
    public RapidReload() : base("Rapid Reload", FeatType.Combat) {
        Prerequisites = [
			//TODO add the shit
		];
    }

    public override bool CanAcquire(Player.Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player.Player player) {
        throw new NotImplementedException();
    }
}