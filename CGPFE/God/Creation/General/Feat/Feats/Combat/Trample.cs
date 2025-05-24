using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class Trample: Feat {
	public Trample() : base("Trample", FeatType.Combat) {
		Prerequisites = [
			new SkillRankPrerequisite("Ride", 1),
			new FeatPrerequisite("Mounted Combat")
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}