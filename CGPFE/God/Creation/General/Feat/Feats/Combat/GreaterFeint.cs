using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class GreaterFeint: Feat {
	public GreaterFeint() : base("Greater Feint", FeatType.Combat) {
		Prerequisites = [
			new FeatPrerequisite("Combat Expertise"),
			new FeatPrerequisite("Improved Feint"),
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