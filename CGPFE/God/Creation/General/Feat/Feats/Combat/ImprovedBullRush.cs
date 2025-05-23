using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class ImprovedBullRush: Feat {
	public ImprovedBullRush() : base("Improved Bull Rush", FeatType.Combat) {
		Prerequisites = [
			new ValuePrerequisite("Str", 13),
			new FeatPrerequisite("Power Attack"),
			new ValuePrerequisite("Bab", 1)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}