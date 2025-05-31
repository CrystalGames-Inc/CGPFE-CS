using CGPFE.Core.Enums;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Critical;

public class BleedingCritical: Domain.Characters.Feats.Properties.Feat {
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