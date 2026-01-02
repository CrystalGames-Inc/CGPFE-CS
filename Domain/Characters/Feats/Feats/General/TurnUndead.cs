using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class TurnUndead: Domain.Characters.Feats.Properties.Feat {
	public TurnUndead() : base("Turn Undead") {
		Prerequisites = [
			//TODO add the prerequisites
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}