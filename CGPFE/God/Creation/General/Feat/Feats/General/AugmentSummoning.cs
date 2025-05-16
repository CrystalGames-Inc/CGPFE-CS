using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.General;

public class AugmentSummoning: Feat {
	public AugmentSummoning() : base("Augment Summoning") {
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