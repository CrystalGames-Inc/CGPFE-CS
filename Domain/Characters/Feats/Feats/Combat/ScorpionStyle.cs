using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ScorpionStyle: Domain.Characters.Feats.Properties.Feat {
	public ScorpionStyle() : base("Scorpion Style", FeatType.Combat) {
		Prerequisites = [
			new FeatPrerequisite("Improved Unarmed Strike")
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}