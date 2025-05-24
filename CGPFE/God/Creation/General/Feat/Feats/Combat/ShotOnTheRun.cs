using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class ShotOnTheRun: Feat {
	public ShotOnTheRun() : base("Shot On The Run", FeatType.Combat) {
		Prerequisites = [
			new ValuePrerequisite("Dex", 13),
			new FeatPrerequisite("Dodge"),
			new FeatPrerequisite("Mobility"),
			new FeatPrerequisite("Point-Blank Shot"),
			new ValuePrerequisite("Bab", 4)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}