using CGPFE.Data.Constants;
using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class LightningStance: Feat {
	public LightningStance() : base("Lightning Stance", FeatType.Combat) {
		Prerequisites = [
			new ValuePrerequisite("Dex", 17),
			new FeatPrerequisite("Dodge"),
			new FeatPrerequisite("Wind Stance"),
			new ValuePrerequisite("Bab", 11)
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}