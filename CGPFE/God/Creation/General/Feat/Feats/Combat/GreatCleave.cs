using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class GreatCleave: Feat {
	public GreatCleave() : base("Great Cleave", FeatType.Combat) {
		Prerequisites = [
			new ValuePrerequisite("Str", 13),
			new FeatPrerequisite("Cleave"),
			new FeatPrerequisite("Power Attack"),
			new ValuePrerequisite("Bab", 4) 
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}