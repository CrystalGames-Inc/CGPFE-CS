using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class CriticalMastery: Feat {
	public CriticalMastery() : base("Critical Mastery", FeatType.Combat) {
		Prerequisites = [
			new FeatPrerequisite("Critical Focus"),
			new ValuePrerequisite("Lvl", 14),
			new ValuePrerequisite("Cls", 7, "==")
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}