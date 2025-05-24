using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class SnatchArrows: Feat {
	public SnatchArrows() : base("Snatch Arrows", FeatType.Combat) {
		Prerequisites = [
			new ValuePrerequisite("Dex", 15),
			new FeatPrerequisite("Deflect Arrows"),
			new FeatPrerequisite("Improved Unarmed Strike")
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}