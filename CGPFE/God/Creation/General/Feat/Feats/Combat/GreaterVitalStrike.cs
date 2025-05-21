using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class GreaterVitalStrike: Feat {
	public GreaterVitalStrike() : base("Greater Vital Strike", FeatType.Combat) {
		Prerequisites = [
			new FeatPrerequisite("Improved Vital Strike"),
			new FeatPrerequisite("Vital Strike"),
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