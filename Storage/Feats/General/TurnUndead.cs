using Domain.Characters.Feat;
using Domain.Characters.Player;

namespace Storage.Feats.General;

public class TurnUndead : Feat
{
    public TurnUndead() : base("Turn Undead") {
        Prerequisites = [
			//TODO add the prerequisites
		];
    }

    public override bool CanAcquire(Player player) {
        return Prerequisites.All(p => p.IsSatisfiedBy(player));
    }

    public override void ApplyBenefits(ref Player player) {
        throw new NotImplementedException();
    }
}