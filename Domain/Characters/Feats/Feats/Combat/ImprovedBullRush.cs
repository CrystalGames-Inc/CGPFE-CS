using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ImprovedBullRush: Domain.Characters.Feats.Properties.Feat {
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