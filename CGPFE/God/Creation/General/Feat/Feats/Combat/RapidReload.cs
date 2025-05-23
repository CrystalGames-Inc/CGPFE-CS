using CGPFE.Data.Constants;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feat.Feats.Combat;

public class RapidReload: Feat {
	public RapidReload() : base("Rapid Reload", FeatType.Combat) {
		Prerequisites = [
			//TODO add the shit
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}