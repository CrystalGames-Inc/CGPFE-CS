using CGPFE.Data.Constants;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Critical;

public class BleedingCritical: Feat {
	public BleedingCritical() : base("Bleeding Critical", FeatType.Critical) {
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