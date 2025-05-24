using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class Unseat: Feat {
	public Unseat() : base("Unseat", FeatType.Combat) {
		Prerequisites = [
			new ValuePrerequisite("Str", 13),
			new SkillRankPrerequisite("Ride", 1),
			new FeatPrerequisite("Mounted Combat"),
			new FeatPrerequisite("Power Attack"),
			new FeatPrerequisite("Improved Bull Rush"),
			new ValuePrerequisite("Bab", 1)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}