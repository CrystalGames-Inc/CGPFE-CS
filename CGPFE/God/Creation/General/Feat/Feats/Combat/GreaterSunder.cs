using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class GreaterSunder: Feat {
	public GreaterSunder() : base("Greater Sunder", FeatType.Combat) {
		Prerequisites = [
			new FeatPrerequisite("Improved Sunder"),
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