using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class DazzlingDisplay: Domain.Characters.Feats.Properties.Feat {
	public DazzlingDisplay() : base("Dazzling Display", FeatType.Combat) {
		Prerequisites = [
			new FeatPrerequisite("Weapon Focus")
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}