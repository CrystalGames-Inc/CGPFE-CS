using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class ImprovedFeint: Feat {
	public ImprovedFeint() : base("Improved Feint", FeatType.Combat) {
		Prerequisites = [
			new ValuePrerequisite("Int", 13),
			new FeatPrerequisite("Combat Expertise")
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}