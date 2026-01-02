using CGPFE.Core.Enums;
using CGPFE.Domain.Characters.Feats.Properties.Prerequisites;
using CGPFE.Management;

namespace CGPFE.Domain.Characters.Feats.Feats.Combat;

public class ImprovedDisarm: Domain.Characters.Feats.Properties.Feat {
	public ImprovedDisarm() : base("Improved Disarm", FeatType.Combat) {
		Prerequisites = [
			new ValuePrerequisite("Int", 13),
			new FeatPrerequisite("Combat Expertise")
		];
	}

	public override bool CanAcquire() {
		return Prerequisites.All(p => p.IsSatisfiedBy(PlayerDataManager.Instance.Player));
	}

	public override void Benefits() {
		throw new NotImplementedException();
	}
}