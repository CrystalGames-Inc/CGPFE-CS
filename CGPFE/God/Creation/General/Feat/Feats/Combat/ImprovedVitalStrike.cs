using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class ImprovedVitalStrike: Feat {
	public ImprovedVitalStrike() : base("Improved Vital Strike", FeatType.Combat) {
		Prerequisites = [
			new FeatPrerequisite("Vital Strike"),
			new ValuePrerequisite("Bab", 11)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}