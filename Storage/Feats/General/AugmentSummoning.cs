using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class AugmentSummoning: Characters.Feats.Feat {
	public AugmentSummoning() : base("Augment Summoning") {
		Prerequisites = [

		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void ApplyBenefits() {
		throw new NotImplementedException();
	}
}