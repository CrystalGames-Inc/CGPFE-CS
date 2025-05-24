using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Critical;

public class StunningCritical: Feat {
	public StunningCritical() : base("Stunning Critical", FeatType.Critical) {
		Prerequisites = [
			new FeatPrerequisite("Critical Focus"),
			new FeatPrerequisite("Staggering Critical"),
			new ValuePrerequisite("Bab", 17)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}