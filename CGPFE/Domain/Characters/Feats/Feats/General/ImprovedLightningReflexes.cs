using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.General;

public class ImprovedLightningReflexes: Domain.Characters.Feats.Properties.Feat {
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