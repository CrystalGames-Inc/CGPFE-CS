using CGPFE.Data.Constants;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feats.Feats.Combat;

public class ArcaneStrike: Feat {
	public ArcaneStrike() : base("Arcane Strike", FeatType.Combat) {
		Prerequisites = [
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}