using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.General;

public class TurnUndead: Feat {
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