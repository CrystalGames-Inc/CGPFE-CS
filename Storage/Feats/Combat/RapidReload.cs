using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feat;
using CGPFE.Domain.Characters.Player;
using Domain.Characters.Feat;

namespace CGPFE.Storage.Feats.Combat;

public class RapidReload : Feat
{
    public RapidReload() : base("Rapid Reload", FeatType.Combat) {
        Prerequisites = [
			//TODO add the shit
		];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}