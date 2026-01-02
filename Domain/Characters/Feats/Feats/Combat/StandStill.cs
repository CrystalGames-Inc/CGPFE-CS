using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class StandStill: Domain.Characters.Feats.Properties.Feat {
	public StandStill() : base("Stand Still", FeatType.Combat) {
		Prerequisites = [
			new FeatPrerequisite("Combat Reflexes")
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}