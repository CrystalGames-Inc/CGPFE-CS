using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class GreaterOverrun: Feat {
	public GreaterOverrun() : base("Greater Overrun", FeatType.Combat) {
		Prerequisites = [
			new FeatPrerequisite("Improved Overrun"),
			new FeatPrerequisite("Power Attack"),
			new ValuePrerequisite("Bab", 6),
			new ValuePrerequisite("Str", 13)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}