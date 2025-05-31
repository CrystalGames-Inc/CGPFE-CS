using CGPFE.Core.Enums;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ArcaneStrike: Domain.Characters.Feats.Properties.Feat {
	public ArcaneStrike() : base("Arcane Strike", FeatType.Combat) {
		Prerequisites = [
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}