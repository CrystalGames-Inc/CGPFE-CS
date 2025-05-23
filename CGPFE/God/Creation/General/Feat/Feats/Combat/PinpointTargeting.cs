using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class PinpointTargeting: Feat {
	public PinpointTargeting() : base("Pinpoint Targeting", FeatType.Combat) {
		Prerequisites = [
			new ValuePrerequisite("Dex", 19),
			new FeatPrerequisite("Improved Precise Shot"),
			new FeatPrerequisite("Point-Blank Shot"),
			new FeatPrerequisite("Precise Shot"),
			new ValuePrerequisite("Bab", 16)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}