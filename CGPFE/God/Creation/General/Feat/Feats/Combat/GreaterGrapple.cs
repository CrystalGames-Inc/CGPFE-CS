using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class GreaterGrapple: Feat {
	public GreaterGrapple() : base("Greater Grapple", FeatType.Combat) {
		Prerequisites = [
			new FeatPrerequisite("Improved Grapple"),
			new FeatPrerequisite("Improved Unarmed Strike"),
			new ValuePrerequisite("Bab", 6),
			new ValuePrerequisite("Dex", 13)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}