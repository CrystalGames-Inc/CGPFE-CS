using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class SpiritedCharge: Feat {
	public SpiritedCharge() : base("Spirited Charge", FeatType.Combat) {
		Prerequisites = [
			new SkillRankPrerequisite("Ride", 1),
			new FeatPrerequisite("Mounted Combat"),
			new FeatPrerequisite("Ride-By Attack")
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}