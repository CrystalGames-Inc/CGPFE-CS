using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class StunningFist: Feat {
	public StunningFist() : base("Stunning Fist", FeatType.Combat) {
		Prerequisites = [
			new ValuePrerequisite("Dex", 13),
			new ValuePrerequisite("Wis", 13),
			new FeatPrerequisite("Improved Unarmed Strike"),
			new ValuePrerequisite("Bab", 8)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}