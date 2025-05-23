using CGPFE.God.Creation.General.Feat.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.General;

public class ImprovedLightningReflexes: Feat {
	public ImprovedLightningReflexes() : base("Improved Lightning Reflexes") {
		Prerequisites = [
			new FeatPrerequisite("Lightning Reflexes")
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}