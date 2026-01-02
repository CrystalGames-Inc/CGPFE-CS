using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class SpiritedCharge: Domain.Characters.Feats.Properties.Feat {
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