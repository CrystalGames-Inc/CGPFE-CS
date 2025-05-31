using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class GreaterDisarm: Domain.Characters.Feats.Properties.Feat {
	public GreaterDisarm() : base("Greater Disarm", FeatType.Combat) {
		Prerequisites = [
			new FeatPrerequisite("Combat Expertise"),
			new FeatPrerequisite("Improved Disarm"),
			new ValuePrerequisite("Bab", 6),
			new ValuePrerequisite("Int", 13)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}