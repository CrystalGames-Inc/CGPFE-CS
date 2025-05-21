using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class GreaterShieldFocus: Feat {
	public GreaterShieldFocus() : base("Greater Shield Focus", FeatType.Combat) {
		Prerequisites = [
			new FeatPrerequisite("Shield Focus"),
			new FeatPrerequisite("Shield Proficiency"),
			new ValuePrerequisite("Cls", 7, "=="),
			new ValuePrerequisite("Lvl", 8)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}