using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ShotOnTheRun: Domain.Characters.Feats.Properties.Feat {
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