using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Critical;

public class BlindingCritical: Feat {
	public BlindingCritical() : base("Blinding Critical", FeatType.Critical) {
		Prerequisites = [
			new FeatPrerequisite("Critical Focus"),
			new ValuePrerequisite("Bab", 15)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}