using CGPFE.Core.Enums;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class RapidReload: Domain.Characters.Feats.Properties.Feat {
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